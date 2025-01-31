#include <iostream>
#include <thread>
#include <vector>
#include <string>
#include <chrono>
#include <random>
#include <nlohmann/json.hpp>
#include <sys/socket.h>
#include <netinet/in.h>
#include <netdb.h>
#include <arpa/inet.h>
#include <unistd.h>

using json = nlohmann::json;

#define SWITCH_PORT "8885"
#define SWITCH_IP "ec2-35-173-211-118.compute-1.amazonaws.com"

std::string hostname = SWITCH_IP;

// Dummy account details
const std::vector<std::string> dummyAccounts = {
    "7224567890123456",
    "1412567890123456",
    "5809567890123456"
};

// and their PINs
const std::vector<std::string> dummyPins = {
    "2351",
    "5842",
    "1010"
};

// and their expiry dates
const std::vector<std::string> expiryDates = {
    "08/26",
    "04/25",
    "05/26"
};

// function to sim an ATM transaction
void simulateATM(int atmID, int numTransactions, int transactionInterval) {
    char buffer[512];

    int sock;
    struct addrinfo hints, *servinfo, *p;
    int rv;
    char s[INET6_ADDRSTRLEN];

    memset(&hints, 0, sizeof hints);
    hints.ai_family = AF_UNSPEC;
    hints.ai_socktype = SOCK_STREAM;

    // connect to switch
    if ((rv = getaddrinfo(hostname.c_str(), SWITCH_PORT, &hints, &servinfo)) != 0) {
        fprintf(stderr, "getaddrinfo: %s\n", gai_strerror(rv));
        std::cout << "failed to resolve data" << std::endl;
        std::cerr << "[ERROR] ATM " << atmID << ": Socket creation failed.\n";
        exit(1);
    }

    for(p = servinfo; p != NULL; p = p->ai_next) {
        if ((sock = socket(p->ai_family, p->ai_socktype,
                p->ai_protocol)) == -1) {
            perror("client: socket");
            continue;
        }

        if (connect(sock, p->ai_addr, p->ai_addrlen) == -1) {
            close(sock);
            perror("client: connect");
            continue;
        }

        break;
    }

    if (p == NULL) {
        fprintf(stderr, "client: failed to connect\n");
        sleep(10);
        return;
    }

    std::cout << "[INFO] ATM " << atmID << ": Connected to switch.\n";

    //random
    std::random_device rd;
    std::mt19937 generator(rd());
    std::uniform_int_distribution<int> accountDist(0, dummyAccounts.size() - 1);
    std::uniform_int_distribution<int> requestTypeDist(0, 1); // 0-Validate PIN, 1- Balance Inquiry


    //simming transactions
    for (int i = 0; i < numTransactions; ++i) {
        int accountIndex = accountDist(generator);
        std::string pan = dummyAccounts[accountIndex];
        std::string pin = dummyPins[accountIndex];
        std::string expiry = expiryDates[accountIndex];

        json request;
        request["atm_id"] = std::to_string(atmID);
        request["transaction_id"] = "TXN" + std::to_string(atmID * 1000 + i);
        request["pan_number"] = pan;
        request["expiry_date"] = expiry;
        request["pin"] = pin;

        // switching between PIN validation (0) and balance inquiry (1)
        int requestType = requestTypeDist(generator);
        request["request_type"] = std::to_string(requestType);  

        std::string requestStr = request.dump();
        send(sock, requestStr.c_str(), requestStr.size(), 0);

        int bytesReceived = recv(sock, buffer, sizeof(buffer) - 1, 0);

        //feedback
        if (bytesReceived > 0) {
            
            buffer[bytesReceived] = '\0';
            std::cout << "[SUCCESS] ATM " << atmID << ": Response: " << buffer << "\n";
        } else {

            std::cerr << "[ERROR] ATM " << atmID << ": No response from switch.\n";
        }

        std::this_thread::sleep_for(std::chrono::seconds(transactionInterval));  
    }

    close(sock);
}

int main() {

    int numATMs;  
    int transactionsPerATM;  
    int transactionInterval;  

    std::cout << "Enter number of ATMs: ";
    std::cin >> numATMs;  // UI for number of ATMs

    std::cout << "Enter transactions per ATM: ";
    std::cin >> transactionsPerATM;  // UI for transactions per ATM

    std::cout << "Enter interval between transactions (in seconds): ";
    std::cin >> transactionInterval;  // UI for transaction interval (now in seconds)

    std::vector<std::thread> threads;

    for (int i = 0; i < numATMs; ++i) {
        threads.emplace_back(simulateATM, i + 1, transactionsPerATM, transactionInterval);
        std:usleep(500000);
    }

    for (auto& thread : threads) {
        thread.join();
    }

    std::cout << "[INFO] Stress test completed successfully.\n";

    return 0;
}
