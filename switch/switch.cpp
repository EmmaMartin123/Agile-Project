#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <errno.h>
#include <string.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <netdb.h>
#include <arpa/inet.h>
#include <sys/wait.h>
#include <signal.h>
#include <thread>
#include <vector>
#include <mutex>
#include <poll.h>

#include <fstream>
#include <nlohmann/json.hpp>
using json = nlohmann::json;

#define SWITCH_PORT "8885" // the port ATMs will be connecting to
#define BACKLOG 10         // how many pending connections queue will hold

// Sim network types
enum NetworkType {
    NETWORK_VISA = 0,
    NETWORK_MASTERCARD = 1,
    NETWORK_UNIONPAY = 2,
    NETWORK_UNKNOWN = 3
};

// Map PAN first digit to network type
NetworkType getNetworkType(const std::string& pan) {
    if (pan.empty()) return NETWORK_UNKNOWN;

    char firstDigit = pan[0];
    switch (firstDigit) {
        case '1': case '2': case '3': return NETWORK_VISA; // pan 1-3 
        case '4': case '5': case '6': return NETWORK_MASTERCARD; // pan 4-6 
        case '7': case '8': case '9': return NETWORK_UNIONPAY; // pans 7-9 
        default: return NETWORK_UNKNOWN;
    }
}

// Map network type to simulator port
std::string getSimulatorPort(NetworkType network) {
    switch (network) { 
        case NETWORK_VISA: return "8886"; // visa sim port
        case NETWORK_MASTERCARD: return "8884"; // mastercard sim port
        case NETWORK_UNIONPAY: return "8887"; // unionPay sim port
        default: return ""; // for a unknown network
    }
}

// simulator connections
std::unordered_map<NetworkType, int> simulator_fds; // mapping network type to simulator file descriptor
std::vector<int> queuedSockets;
std::vector<struct pollfd> ATMs;

std::mutex queuedSocketsMutex;
std::mutex simulatorFdsMutex;


// Logging function 
void logTransaction(int transactionType, const json &request) {
    std::ofstream logFile("transactions.log", std::ios_base::app); // opening in append mode

    if (!logFile.is_open()){
        return;
    }

    std::time_t now = std::time(nullptr);
    std::tm *localTime = std::localtime(&now);

    logFile << "[" << std::put_time(localTime, "%Y-%m-%d %H:%M:%S") << "] ";

    // always expecting atm_id and pan_number
    std::string atmID = request["atm_id"];
    std::string panNumber = request["pan_number"];

    logFile << " card " << panNumber << " is at ATM: " << atmID << " making request: ";

    switch (transactionType)
    {
    case 0: // Validate Pin
        logFile << "Validate Pin with PIN: " << request["pin"];
        break;
    case 1: // Display Balance
        logFile << "Display Balance ";
        break;
    case 2: // Withdraw
        logFile << "Withdraw Cash of amount: " << request["transaction_value"];
        break;
    default:
        logFile << "Invalid request: " << request.dump();
        break;
    }

    logFile << "\n";
}

// get sockaddr, IPv4 or IPv6:
void *getInAddr(struct sockaddr *sa)
{
    if (sa->sa_family == AF_INET) {
        return &(((struct sockaddr_in*)sa)->sin_addr);
    }

    return &(((struct sockaddr_in6*)sa)->sin6_addr);
}

// connect to a specific simulator based on port
int connectToSimulator(const std::string& port) {

    int sockfd;
    struct addrinfo hints, *servinfo, *p;
    int rv;
    char s[INET6_ADDRSTRLEN];

    memset(&hints, 0, sizeof hints);
    hints.ai_family = AF_UNSPEC;
    hints.ai_socktype = SOCK_STREAM;

    std::string hostname = "127.0.0.1"; // Simulator is on localhost

    // set up data for connection
    if ((rv = getaddrinfo(hostname.c_str(), port.c_str(), &hints, &servinfo)) != 0) {
        fprintf(stderr, "getaddrinfo: %s\n", gai_strerror(rv));
        return -1;
    }

    // loop through all the results and connect to the first we can
    for(p = servinfo; p != NULL; p = p->ai_next) {
        if ((sockfd = socket(p->ai_family, p->ai_socktype, p->ai_protocol)) == -1) {
            perror("client: socket");
            continue;
        }

        if (connect(sockfd, p->ai_addr, p->ai_addrlen) == -1) {
            close(sockfd);
            perror("client: connect");
            continue;
        }

        break;
    }

    if (p == NULL) {
        fprintf(stderr, "client: failed to connect to simulator on port %s\n", port.c_str());
        freeaddrinfo(servinfo);
        return -1;
    }

    inet_ntop(p->ai_family, getInAddr((struct sockaddr *)p->ai_addr), s, sizeof s);
    printf("client: connecting to simulator on port %s\n", port.c_str());

    freeaddrinfo(servinfo); // all done with this structure

    return sockfd;
}

// forward request to appropriate simulator based on pan
int forwardToSimulator(const json &request, int atm_fd) {
    std::string requestStr = request.dump(); // serializing JSON

    // pull pan from request
    std::string panNumber = request["pan_number"];
    NetworkType network = getNetworkType(panNumber);
    std::string port = getSimulatorPort(network);

    if (port.empty()) {
        std::cerr << "Unknown network type for PAN: " << panNumber << "\n";
        return -1;
    }

    // a check to see if we already have a connection to this simulator
    simulatorFdsMutex.lock();
    if (simulator_fds.find(network) == simulator_fds.end()) {
        // connect to the simulator
        int sockfd = connectToSimulator(port);
        if (sockfd == -1) {
            simulatorFdsMutex.unlock();
            return -1;
        }
        simulator_fds[network] = sockfd;
    }
    int simulator_fd = simulator_fds[network];
    simulatorFdsMutex.unlock();

    // sending request to the simulator
    if (send(simulator_fd, requestStr.c_str(), requestStr.size(), 0) == -1) {
        perror("Error sending request to simulator");
        return -1;
    }

    // handle simulator response
    char responseBuffer[512];
    int bytesReceived = recv(simulator_fd, responseBuffer, sizeof(responseBuffer) - 1, 0);
    if (bytesReceived > 0) {
        responseBuffer[bytesReceived] = '\0';
        std::string response(responseBuffer);

        // forward simulator's response to the ATM
        if (send(atm_fd, response.c_str(), response.size(), 0) == -1) {
            perror("Error sending response to ATM");
        }
    } else if (bytesReceived == 0) {

        std::cerr << "Simulator connection closed unexpectedly.\n";
        json response;
        response["transaction_outcome"] = 10;
        response["reason"] = "connection terminated";
        std::string responseStr = response.dump();

        send(atm_fd, responseStr.c_str(), responseStr.length(), 0);
    } else {

        perror("Error receiving response from simulator");
        json response;
        response["transaction_outcome"] = 10;    
        response["reason"] = "error with response";
        std::string responseStr = response.dump();
        
        send(atm_fd, responseStr.c_str(), responseStr.length(), 0);
    }

    return 0;
}

// for all the sockets we are working with, check if they have received inputs
void pollingFunction(){
    char buff[512];

    // check all ports regularly
    while (1)
    {
        int num_events = poll(&(*(ATMs.begin())), ATMs.size(), 150);

        // only scan the ports for data if an event has happened
        if (num_events > 0)
        {
            // check for something in the event that poll doesn't timeout
            for (int i = 0; i < ATMs.size(); i++)
            {
                if (ATMs[i].revents & POLLIN)
                {
                    int bytesReceived = recv(ATMs[i].fd, buff, 512, 0);
                    if (bytesReceived > 0)
                    {
                        buff[bytesReceived] = '\0'; // Null-terminate the received data 
                        std::string data(buff);

                        json request;

                        try {
                            // parsing JSON data 
                            request = json::parse(data);

                            // extracting relevant fields 
                            std::string s_transactionType = request["request_type"];
                            int transactionType = std::stoi(s_transactionType);

                            // logging the transaction 
                            logTransaction(transactionType, request);

                            // forwarding request to simulator
                            int responseReachedNetwork = forwardToSimulator(request, ATMs[i].fd);

                            if (responseReachedNetwork != 0)
                            { // connection to network broken, send ATM error response
                                request["transaction_outcome"] = 10;
                                request["reason"] = "connection terminated";
                                std::string response = request.dump();
                                send(ATMs[i].fd, response.c_str(), response.length(), 0);
                            }

                        } catch (const std::exception &e) {
                            std::cerr << "Error parsing transaction data: " << e.what() << std::endl;
                            std::cerr << "request is: " << request.dump() << "\n";
                            request["transaction_outcome"] = 10;
                            request["reason"] = e.what();
                            std::string response = request.dump();
                            send(ATMs[i].fd, response.c_str(), response.length(), 0);
                        }

                        memset(buff, 0, 512);
                    }

                    ATMs[i].revents = 0;
                }
            }
        }

        // add any pending connections
        queuedSocketsMutex.lock();

        auto current = queuedSockets.begin();
        auto end = queuedSockets.end();

        while (current != end)
        {
            ATMs.push_back(pollfd{*current, POLLIN, 0});
            current = next(current);
        }

        queuedSockets.clear();

        queuedSocketsMutex.unlock();
    }
}

int bindSocketForClientsAndListen(){
    // data structs and processing variables
    int sockfd, new_fd;  // listen on sock_fd, new connection on new_fd
    struct addrinfo hints, *servinfo, *p;
    struct sockaddr_storage their_addr; // connector's address information
    socklen_t sin_size;
    struct sigaction sa;
    int yes=1;
    char s[INET6_ADDRSTRLEN];
    int rv;

    // zero out addressinfor structs to prevent old data in memory altering program
    memset(&hints, 0, sizeof hints);
    hints.ai_family = AF_UNSPEC;
    hints.ai_socktype = SOCK_STREAM;
    hints.ai_flags = AI_PASSIVE; // use my IP

    if ((rv = getaddrinfo(NULL, SWITCH_PORT, &hints, &servinfo)) != 0) {
        fprintf(stderr, "getaddrinfo: %s\n", gai_strerror(rv));
        return 1;
    }

    // loop through all the results and bind to the first we can
    for(p = servinfo; p != NULL; p = p->ai_next) {
        if ((sockfd = socket(p->ai_family, p->ai_socktype,
                p->ai_protocol)) == -1) {
            perror("server: socket");
            continue;
        }

        if (setsockopt(sockfd, SOL_SOCKET, SO_REUSEADDR, &yes,
                sizeof(int)) == -1) {
            perror("setsockopt");
            exit(1);
        }

        if (bind(sockfd, p->ai_addr, p->ai_addrlen) == -1) {
            close(sockfd);
            perror("server: bind");
            continue;
        }

        break;
    }

    freeaddrinfo(servinfo); // all done with this structure

    if (p == NULL)  {
        fprintf(stderr, "server: failed to bind\n");
        exit(1);
    }

    if (listen(sockfd, BACKLOG) == -1) {
        perror("listen");
        exit(1);
    }

    printf("server: waiting for connections...\n");

    while(1) {  // main accept() loop
        sin_size = sizeof their_addr;
        new_fd = accept(sockfd, (struct sockaddr *)&their_addr, &sin_size);
        if (new_fd == -1) {
            perror("accept");
            continue;
        }

        inet_ntop(their_addr.ss_family,
            getInAddr((struct sockaddr *)&their_addr),
            s, sizeof s);
        printf("server: got connection from %s\n", s);

        // get the mutex lock on the incoming connections queue
        queuedSocketsMutex.lock();

        // add the new connection to the queue
        queuedSockets.push_back(new_fd);

        // unlock the mutex to allow the other thread to add the sockets to it's list
        queuedSocketsMutex.unlock();
    }

    return 0;
}

int main(int argc, char *argv[])
{
    // set up a thread to handle clients
    std::thread pollingThread(pollingFunction);
    // start accepting clients
    bindSocketForClientsAndListen();

    return 0;
}