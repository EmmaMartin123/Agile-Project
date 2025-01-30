﻿using Newtonsoft.Json;
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

        private static void HandleDroppedConnection()
        {

            // notifies the user of the connection problem with a dialog box
            //MessageBox.Show("Problem with transaction, returning card...", "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            AlertMessageForm alertMessageForm = new AlertMessageForm("Problem with transaction, returning card...");
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
        public static string connectionAddress = "ec2-52-91-1-195.compute-1.amazonaws.com";
        public static decimal CurrentBalance = 500;
        public static int transactionType = -1;
        public static int ATMID = 0;
        public static string PAN = "2234567890123456";
        public static int PIN = 1010;
        
        /* 
         Card Types:
        Mastercard - starts with a 5
        Visa - starts with a 4
        UnionPay - starts with 62
        Amex - starts with 34 or 37
         */
        public static string mastercardPAN = "5809567890123456";
        public static string visaPAN = "4412567890123456";
        public static string unionpayPAN = "6224567890123456";
        public static string amexPAN = "3477567890123456";
        public static string currentPAN = "";
        public static string currentCardType = "";

    }

}
