import socket
import json
import time

# Switch connection details
SWITCH_HOST = "127.0.0.1"
SWITCH_PORT = 8885  # The switch is listening on this port

# Function to send a transaction request
def send_transaction(pan_number, request_type, atm_id, transaction_value=None, pin=None, expiry_date=None):
    request = {
        "atm_id": atm_id,
        "pan_number": pan_number,
        "request_type": str(request_type),
    }

    if pin is not None:
        request["pin"] = pin
    if transaction_value is not None:
        request["transaction_value"] = str(transaction_value)
    if expiry_date is not None:
        request["expiry_date"] = expiry_date

    request_json = json.dumps(request)
    print(f"\n📨 Sending request to switch: {request_json}")

    # Send request to switch
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as client_socket:
        client_socket.settimeout(5)

        try:
            client_socket.connect((SWITCH_HOST, SWITCH_PORT))
            print(f"✅ Connected to switch at {SWITCH_HOST}:{SWITCH_PORT}")

            # 🔹 Ensure all data is sent
            total_sent = 0
            while total_sent < len(request_json):
                sent = client_socket.send(request_json[total_sent:].encode())
                if sent == 0:
                    print("❌ Connection lost while sending data")
                    return
                total_sent += sent
            
            print("📤 Request successfully sent. Waiting for response...")

            try:
                response = client_socket.recv(1024).decode()
                print(f"📩 Response from switch: {response}")

            except socket.timeout:
                print("❌ Timeout: No response received from switch.")

        except ConnectionRefusedError:
            print(f"❌ Failed to connect to switch at {SWITCH_HOST}:{SWITCH_PORT}")
        except Exception as e:
            print(f"❌ Unexpected error: {e}")

# Test transactions
if __name__ == "__main__":
    print("\n🚀 Testing transactions on the switch...\n")
    time.sleep(1)

    send_transaction("5432109876543210", request_type=0, atm_id="Mastercard", pin="1234", expiry_date="12/26")
    send_transaction("4123456789012345", request_type=0, atm_id="Visa", pin="5678", expiry_date="11/25")
    send_transaction("6123456789012345", request_type=0, atm_id="UnionPay", pin="9876", expiry_date="10/27")
    send_transaction("312345678901234", request_type=0, atm_id="AmericanExpress", pin="2468", expiry_date="09/28")




