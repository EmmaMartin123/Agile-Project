import socket
import json

SWITCH_IP = "127.0.0.1"  
SWITCH_PORT = 8885

# example transaction request
transaction_request = {
    "request_type": "withdraw",
    "atm_id": "ATM001",
    "transaction_id": "TXN12345",
    "card_number": "1234567890123456",
    "expiry_date": "12/25",
    "pin": "1234",
    "withdrawal_amount": 100.0
}

def send_transaction(request):
    try:
        # connect to switch
        client_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
        client_socket.connect((SWITCH_IP, SWITCH_PORT))

        # send request
        client_socket.send(json.dumps(request).encode())

        # recieve  response
        response = client_socket.recv(512).decode()
        print("Response from switch:", response)

        client_socket.close()
    except Exception as e:
        print(f"Error communicating with switch: {e}")

if __name__ == "__main__":
    send_transaction(transaction_request)
