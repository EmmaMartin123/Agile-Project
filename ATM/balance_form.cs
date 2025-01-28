using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_forms
{
    public partial class BalanceForm : Form
    {
        public BalanceForm()
        {
            InitializeComponent();
        }

        private void BalanceformLoad(object sender, EventArgs e)
        {
            // send the balance request to the switch to deal with
            try
            {
                // connect and send response in json format
                NetworkClient.ConnectToSwitch(TransactionData.connectionAddress, 8885);
                NetworkClient.SendRequest("{\"request_type\": \"" + TransactionData.transactionType + "\", \"atm_id\":\"" + TransactionData.ATMID + "\", \"pan_number\":\"" + TransactionData.currentPAN + "\",\"pin\":\"" + TransactionData.PIN + "\",\"card_type\":\"" + TransactionData.currentCardType + "\"}");
                string response = NetworkClient.ReceiveResponse();
                Console.WriteLine($"Response: {response}");
                NetworkClient.CloseConnection();

                dynamic parsedResponse = JsonConvert.DeserializeObject(response);
                int transaction_value = parsedResponse.transaction_value;

                balance_label.Text = $"£{transaction_value:F2}"; // F2 for two decimal places
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error in network operations: {ex.Message}");
            }
        }

        private void DonebtnClick(object sender, EventArgs e)
        {
            SelectTransactionForm cardForm = new SelectTransactionForm(); // instance of select_transaction_form
            cardForm.Show();
            this.Close();  // terminates this form
        }

        private void balance_label_Click(object sender, EventArgs e)
        {

        }
    }
}
