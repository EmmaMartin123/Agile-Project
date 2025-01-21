/*

switch.cpp, switch server and client program

This program bridges the network simulation and the client ATMs
it needs to have a server threadd open to accept connections from ATMs and queue the
requests it will receive from them and a collection of connections to the ATMs

Best way forward will likely be to do what?

*/

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

#define SIMULATOR_PORT "8884" // the port the switch will be connecting to 
#define SWITCH_PORT "8885" // the port ATMs will be connecting to

#define BACKLOG 10   // how many pending connections queue will hold

#define MAXDATASIZE 100 // max number of bytes we can get at once 

std::vector<int> queuedSockets;
std::vector<struct pollfd> ATMs;

std::mutex queuedSocketsMutex;

// Logging function 
void logTransaction(const std::string &transactionType, const std::string &atmID, 
                    const std::string &transactionID, const std::string &cardNumber, 
                    const std::string &expiryDate, const std::string &pin, 
                    double withdrawalAmount, bool success) {

    std::ofstream logFile("transactions.log", std::ios_base::app); // opening in append mode
    if (logFile.is_open()) {
        std::time_t now = std::time(nullptr);
        std::tm *localTime = std::localtime(&now);

        logFile << "[" << std::put_time(localTime, "%Y-%m-%d %H:%M:%S") << "] ";
        logFile << "ATM ID: " << atmID << ", ";
        logFile << "Transaction ID: " << transactionID << ", ";
        logFile << "Card: " << cardNumber << ", ";
        logFile << "Expiry: " << expiryDate << ", ";
        logFile << "PIN: " << pin << ", ";
        logFile << "Type: " << transactionType << ", ";
        if (transactionType == "withdraw") {
            logFile << "Amount: $" << withdrawalAmount << ", ";
        }

        logFile << "Status: " << (success ? "Success" : "Failed") << "\n";
    }
}

// get sockaddr, IPv4 or IPv6:
void *get_in_addr(struct sockaddr *sa)
{
    if (sa->sa_family == AF_INET) {
        return &(((struct sockaddr_in*)sa)->sin_addr);
    }

    return &(((struct sockaddr_in6*)sa)->sin6_addr);
}

int connectToNetwork(){

    int sockfd;
    struct addrinfo hints, *servinfo, *p;
    int rv;
    char s[INET6_ADDRSTRLEN];

    while (1)
    {
        memset(&hints, 0, sizeof hints);
        hints.ai_family = AF_UNSPEC;
        hints.ai_socktype = SOCK_STREAM;

        // set up data for connection
        if ((rv = getaddrinfo("127.0.0.1", SIMULATOR_PORT, &hints, &servinfo)) != 0) {
            fprintf(stderr, "getaddrinfo: %s\n", gai_strerror(rv));
            std::cout << "failed to resolve data" << std::endl;
            exit(1);
        }

        // loop through all the results and connect to the first we can
        for(p = servinfo; p != NULL; p = p->ai_next) {
            if ((sockfd = socket(p->ai_family, p->ai_socktype,
                    p->ai_protocol)) == -1) {
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
            fprintf(stderr, "client: failed to connect\n");
            sleep(10);
            continue;
        }

        inet_ntop(p->ai_family, get_in_addr((struct sockaddr *)p->ai_addr), s, sizeof s);
        printf("client: connecting to %s\n", s);

        freeaddrinfo(servinfo); // all done with this structure

        return sockfd;
    }
}

void pollingFunction(){
    char buff[512];
    while (1)
    {
        int num_events = poll(&(*(ATMs.begin())), ATMs.size(), 150);

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
                        buff[bytesReceived] = '\0'; // Null-terminate the received data ###############################33333333
                        std::string data(buff);

                        try {
                            // parsing JSON data 
                            json request = json::parse(data);

                            // extracting relevant fields 
                            std::string transactionType = request["request_type"];
                            std::string atmID = request["atm_id"];
                            std::string transactionID = request["transaction_id"];
                            std::string cardNumber = request["card_number"];
                            std::string expiryDate = request["expiry_date"];
                            std::string pin = request["pin"];
                            double withdrawalAmount = request.value("withdrawal_amount", 0.0);

                            // logging transaction 
                            logTransaction(transactionType, atmID, transactionID, cardNumber, expiryDate, pin, withdrawalAmount, true);

                            // Respond back to ATM
                            json response = {
                                {"status", "success"},
                                {"message", "Transaction processed"}
                            };
                            std::string responseStr = response.dump();
                            send(ATMs[i].fd, responseStr.c_str(), responseStr.size(), 0);
                        } catch (const std::exception &e) {
                            std::cerr << "Error parsing transaction data: " << e.what() << std::endl;
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
            get_in_addr((struct sockaddr *)&their_addr),
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

    int networkSim_fd;
    networkSim_fd = connectToNetwork();

    std::thread pollingThread(pollingFunction);
    bindSocketForClientsAndListen();

    
    close(networkSim_fd);
    return 0;
}
