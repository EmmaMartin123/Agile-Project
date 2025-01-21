/*

simulator.cpp, simulator server program

adapted from https://beej.us/guide/bgnet/html/split-wide/client-server-background.html

main loop initiates listening loop and waits for client connections
handleNewConnection is where all logic relevant to handling incoming data should be

*/

#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <unistd.h>
#include <errno.h>
#include <sys/types.h>
#include <sys/socket.h>
#include <netinet/in.h>
#include <netdb.h>
#include <arpa/inet.h>
#include <sys/wait.h>
#include <signal.h>
#include <string>

#include <fstream>
#include <nlohmann/json.hpp>
using json = nlohmann::json;

#define PORT "8884"  // the port users will be connecting to

#define BACKLOG 10   // how many pending connections queue will hold

// a in-memory account database for now (card Number, balance)
std::unordered_map<std::string, double> accounts = {  
    {"1234567890123456", 1000.0},                     
    {"9876543210987654", 500.0}                       
};

void sigchld_handler(int s)
{
    // waitpid() might overwrite errno, so we save and restore it:
    int saved_errno = errno;

    while(waitpid(-1, NULL, WNOHANG) > 0);

    errno = saved_errno;
}


// get sockaddr, IPv4 or IPv6:
void *get_in_addr(struct sockaddr *sa)
{
    if (sa->sa_family == AF_INET) {
        return &(((struct sockaddr_in*)sa)->sin_addr);
    }

    return &(((struct sockaddr_in6*)sa)->sin6_addr);
}

///////////////////////////////////////////////////////
////////            Client Handling         ///////////
///////////////////////////////////////////////////////

// wait to receive data on the connection and then send a response,
// always send a response at the end, even 
void handleNewConnection(int socket){
    char buffer[512];
    int rv; // return value, equals the number of bytes of data received or 0 if connection terminated or -1 in the case of error
    std::string response = "";

    while (true)
    {
        response = "";
        memset(buffer, 0, 512);

        rv = recv(socket, buffer, 512, 0);
        if (rv  == -1)
        {
            // something went wrong
            fprintf(stderr, "recv: %s (%d)\n", strerror(errno), errno);
            break;
        } else if(rv == 0){
            //connection has been closed
            std::cout << "connection closed\n";
            break;
        } else{
            // handleData
            std::cout << buffer << std::endl;

            try {  
                // parsing incoming JSON #
                json request = json::parse(buffer);  

                // Extract transaction details #
                std::string cardNumber = request["card_number"];
                double withdrawalAmount = request.value("withdrawal_amount", 0.0);
                std::string transactionID = request["transaction_id"];

                // preping response #
                json responseJson;
                responseJson["transaction_id"] = transactionID;

                // validation and process transaction #
                if (accounts.find(cardNumber) != accounts.end()) {  
                    double &balance = accounts[cardNumber];         
                    if (withdrawalAmount <= balance) {              
                        balance -= withdrawalAmount;                
                        responseJson["status"] = "approved";        
                        responseJson["remaining_balance"] = balance; 
                    } else {                                        
                        responseJson["status"] = "declined";        
                        responseJson["reason"] = "Insufficient funds"; 
                    }
                } else {                                            
                    responseJson["status"] = "declined";            
                    responseJson["reason"] = "Card not found";      
                }

                // serializing response 
                response = responseJson.dump();                     
            } catch (const std::exception &e) {                     
                response = R"({"status": "error", "message": "Invalid request format"})"; 
            }

            send(socket, response.c_str(), response.length(), 0); // sending response 
        }
    }
    // if we ever leave the loop, the connection has terminated
    close(socket);
}

// set up server and to respond to requests by with a positive response and logging any data passed to it
int main(void)
{

    // data structs and processing variables
    int sock_fd, new_fd;  // listen on sock_fd, new connection on new_fd
    struct addrinfo hints, *servinfo, *p;
    struct sockaddr_storage their_addr; // connector's address information
    socklen_t sin_size;
    struct sigaction sa;
    int yes=1;
    char s[INET6_ADDRSTRLEN];
    int rv; // return value

    // zero out address info structs to prevent old data in memory altering program behaviour
    memset(&hints, 0, sizeof hints);
    hints.ai_family = AF_UNSPEC;
    hints.ai_socktype = SOCK_STREAM;
    hints.ai_flags = AI_PASSIVE; // use my IP

    if ((rv = getaddrinfo(NULL, PORT, &hints, &servinfo)) != 0) {
        fprintf(stderr, "getaddrinfo: %s\n", gai_strerror(rv));
        return 1;
    }

    // loop through all the results and bind to the first we can
    for(p = servinfo; p != NULL; p = p->ai_next) {
        if ((sock_fd = socket(p->ai_family, p->ai_socktype,
                p->ai_protocol)) == -1) {
            perror("server: socket");
            continue;
        }

        if (setsockopt(sock_fd, SOL_SOCKET, SO_REUSEADDR, &yes,
                sizeof(int)) == -1) {
            perror("setsockopt");
            exit(1);
        }

        if (bind(sock_fd, p->ai_addr, p->ai_addrlen) == -1) {
            close(sock_fd);
            perror("server: bind");
            continue;
        }

        break;
    }

    freeaddrinfo(servinfo); // all done with this structure

    // check we are succesfully listening
    if (p == NULL)  {
        fprintf(stderr, "server: failed to bind\n");
        exit(1);
    }

    // check for errors while listening
    if (listen(sock_fd, BACKLOG) == -1) {
        perror("listen");
        exit(1);
    }

    // handle the forked processes as they exit
    sa.sa_handler = sigchld_handler; // reap all dead processes
    sigemptyset(&sa.sa_mask);
    sa.sa_flags = SA_RESTART;
    if (sigaction(SIGCHLD, &sa, NULL) == -1) {
        perror("sigaction");
        exit(1);
    }

    printf("server: waiting for connections...\n");

    while(1) {  // main accept() loop
        sin_size = sizeof their_addr;
        new_fd = accept(sock_fd, (struct sockaddr *)&their_addr, &sin_size);
        if (new_fd == -1) {
            perror("accept");
            continue;
        }

        inet_ntop(their_addr.ss_family,
            get_in_addr((struct sockaddr *)&their_addr),
            s, sizeof s);
        printf("server: got connection from %s\n", s);

        // create a new process running the exact same code, if it is the original, return to loop start
        // otherwise, run internal code
        if (!fork()) { // this is the child process
            close(sock_fd); // child doesn't need the listening socket
            handleNewConnection(new_fd);
            // exiting the handleNewConnection function means we have severed the connection, we exit because it is specifically
            // that client handling fork that is leaving
            exit(0);
        }
        close(new_fd);  // parent doesn't need this
    }

    return 0;
}
