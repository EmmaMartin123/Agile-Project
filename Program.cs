using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_forms
{

    public static class NetworkClient
    {
        public static TcpClient client;
        public static NetworkStream stream;

        //used this for info - https://www.geeksforgeeks.org/socket-programming-in-c-sharp/
        public static void ConnectToSwitch(string ip, int port)
        {
            try
            {
                client = new TcpClient(ip, port);
                stream = client.GetStream();
                Console.WriteLine("connected to switch.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error connecting to switch: {ex.Message}");
            }
        }

        public static void SendRequest(string jsonRequest)
        {
            try
            {
                if (client == null || !client.Connected)
                {
                    Console.WriteLine("error: client is not connected.");
                    return;
                }

                byte[] data = Encoding.UTF8.GetBytes(jsonRequest);
                stream.Write(data, 0, data.Length);
                Console.WriteLine("request sent to switch.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error sending request: {ex.Message}");
            }
        }

        public static string ReceiveResponse()
        {
            if (stream == null)
            {
                Console.WriteLine("error stream is not initialized.");
                return null;
            }

            try
            {
                byte[] buffer = new byte[512];
                int bytesRead = stream.Read(buffer, 0, buffer.Length);
                return Encoding.UTF8.GetString(buffer, 0, bytesRead);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error receiving response: {ex.Message}");
                return null;
            }
        }

        public static void CloseConnection()
        {
            try
            {
                stream?.Close();
                client?.Close();
                Console.WriteLine("Connection closed.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error closing connection: {ex.Message}");
            }
        }
    }
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                // network stuff here
                NetworkClient.ConnectToSwitch("ec2-52-90-113-181.compute-1.amazonaws.com", 8885); // replace the IP???
                NetworkClient.SendRequest("{\"request_type\":\"withdraw\", \"atm_id\":\"5678\", \"transaction_id\":\"1234\", \"card_number\":\"2345678901234567\", \"expiry_date\":\"12/25\", \"pin\":\"1234\", \"withdrawal_amount\":100.0}");
                string response = NetworkClient.ReceiveResponse();
                Console.WriteLine($"Response: {response}");
                NetworkClient.CloseConnection();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error in network operations: {ex.Message}");
            }

            //run the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form insertCardForm = new insert_card_form();
            insertCardForm.Load += new EventHandler(form_load);
            Application.Run(new insert_card_form());
        }

        public static void show_insert_card_form(Form currentForm)
        {
            insert_card_form cardForm = new insert_card_form(); // instance of insert_card_form
            cardForm.Show();
            currentForm.Close();
        }

        // a shared form_load method for all forms to prevent lagging
        public static void form_load(object sender, EventArgs e)
        {
            int w = Screen.PrimaryScreen.Bounds.Width;
            int h = Screen.PrimaryScreen.Bounds.Height;

            if (sender is Form form)
            {
                form.Location = new Point(0, 0);
                form.Size = new Size(w, h);
            }
        }
    }

    public static class TransactionData
    {
        // transaction variables (dummy data for now)
        public static decimal CurrentBalance = 500;
        public static int TransactionID = 1234;
        public static int ATMID = 5678;
        public static string PAN = "2345678901234567";
        public static int PIN = 1234;
    }

}
