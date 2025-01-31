using Newtonsoft.Json;
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
                client = new TcpClient(); //creates a new TCP client instance

                // begins an asynchronous connection attempt to the specified IP and port
                var result = client.BeginConnect(ip, port, null, null);

                // waits for the connection attempt to complete by the given timeout (3 seconds)
                //prevents indefinite blocking if the server is unresponsive
                bool success = result.AsyncWaitHandle.WaitOne(TimeSpan.FromSeconds(3)); // 3s timeout


                // if the connection did not complete within the timeout, throw a timeout exception
                if (!success)
                {
                    throw new SocketException((int)SocketError.TimedOut);
                }

                client.EndConnect(result); // finish connection attempt

                //prevents network operations from getting stuck by setting a time limit
                client.ReceiveTimeout = 5000;
                client.SendTimeout = 5000;
                stream = client.GetStream();

                Console.WriteLine("Connected to switch.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to switch: {ex.Message}");
                HandleDroppedConnection();
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
                Console.WriteLine(jsonRequest);
                Console.WriteLine(data);
                if (data != null && data.Length != null)
                {
                    stream.Write(data, 0, data.Length);
                    Console.WriteLine("request sent to switch.");
                }
               
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

        private static void HandleDroppedConnection()
        {

            // notifies the user of the connection problem with a dialog box
            //MessageBox.Show("Problem with transaction, returning card...", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            AlertMessageForm alertMessageForm = new AlertMessageForm("Connection error, returning card...");
            alertMessageForm.ShowDialog();

            // gets the current form - which is the form where the connection failed so we can close it
            Form currentForm = Application.OpenForms[Application.OpenForms.Count - 1];

            currentForm.Close();

            //takes the user back to the insert card form
            InsertCardForm cardForm = new InsertCardForm();

            cardForm.Show();
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
            // generate random number for the atm id
            Random rnd = new Random();
            TransactionData.ATMID = rnd.Next(1, 10000);
            //run the application
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Form InsertCardForm = new InsertCardForm();
            Application.Run(new InsertCardForm());
        }

        public static void ShowInsertCardForm(Form currentForm)
        {
            InsertCardForm cardForm = new InsertCardForm(); // instance of insert_card_form
            cardForm.Show();
            currentForm.Close();
        }

    }

    public static class TransactionData
    {
        // transaction variables (dummy data for now)
        public static string connectionAddress = "ec2-52-71-77-78.compute-1.amazonaws.com";
        public static decimal CurrentBalance = 500;
        public static int transactionType = -1;
        public static int ATMID = 0;
        public static string PAN = "2234567890123456";
        public static int PIN = 1010;
        

         /*
         Card Types:
        Mastercard - starts with 4/5/6
        Visa - starts with 1/2/3
        UnionPay - starts with 7/8/9
         */
        public static string mastercardPAN = "5809567890123456";
        public static string visaPAN = "1412567890123456";
        public static string unionpayPAN = "7224567890123456";
        public static string currentPAN = "";
        public static string currentCardType = "";
        
    }

    public static class GlobalVariables
    {
        public static string language = "english";
    }


}


  

