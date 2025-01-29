#include <iostream>
#include <thread>
#include <vector>
#include <string>
#include <chrono>
#include <random>
#include <nlohmann/json.hpp>
#include <sys/socket.h>
#include <arpa/inet.h>
#include <unistd.h>

using json = nlohmann::json;

#define SWITCH_PORT 8885
#define SWITCH_IP "127.0.0.1"


// Dummy account details
const std::vector<std::string> dummyAccounts = {
    "4521478523695201",
    "3698521478965412",
    "2234567890123456"
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
    struct sockaddr_in serverAddr;
    char buffer[512];
    int sock;

    //  socket set up
    sock = socket(AF_INET, SOCK_STREAM, 0);
    if (sock < 0) {
        std::cerr << "[ERROR] ATM " << atmID << ": Socket creation failed.\n";
        return;
    }

    serverAddr.sin_family = AF_INET;
    serverAddr.sin_port = htons(SWITCH_PORT);
    inet_pton(AF_INET, SWITCH_IP, &serverAddr.sin_addr);

    //  switch connection
    if (connect(sock, (struct sockaddr*)&serverAddr, sizeof(serverAddr)) < 0) {
        std::cerr << "[ERROR] ATM " << atmID << ": Failed to connect to switch.\n";
        close(sock);
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
        request["atm_id"] = "ATM" + std::to_string(atmID);
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
    }

    for (auto& thread : threads) {
        thread.join();
    }

    std::cout << "[INFO] Stress test completed successfully.\n";

    return 0;
}
