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
    public partial class WithdrawForm : Form
    {
        public WithdrawForm()
        {
            InitializeComponent();
        }


        // single event handler for all number buttons
        private void NumberButtonClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                amount_txtbox.Text += button.Text; // appends the text to the textBox
            }
        }

        // prevents keypress for amount_txtbox
        private void AmounttxtboxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; 
        }

        private void  BtnYClick(object sender, EventArgs e)
        {

            decimal amount;
            string amountText = amount_txtbox.Text.Replace("£", "").Trim(); // removes the pound sign

            // checks the amount entered is valid - must be a multiple of 5 and a valid number
            if (decimal.TryParse(amountText, out amount) && amount > 0 && amount % 5 == 0)
            {
                // send amount to switch to deal with
                try
                {

                    // connect and send response in json format
                    NetworkClient.ConnectToSwitch(TransactionData.connectionAddress, 8885);
                    Console.WriteLine(amount);
                    NetworkClient.SendRequest("{\"request_type\": \"" + TransactionData.transactionType + "\", \"atm_id\":\"" + TransactionData.ATMID + "\", \"pan_number\":\"" + TransactionData.currentPAN + "\",\"pin\":\"" + TransactionData.PIN + "\", \"transaction_value\": \"" + amount + "\"}");
                    //NetworkClient.SendRequest("{\"request_type\": \""+TransactionData.transactionType+"\", \"atm_id\":\"" + TransactionData.ATMID + "\", \"pan_number\":\"" + TransactionData.PAN + "\", \"transaction_value\": \""+amount+"\"}");
                    string response = NetworkClient.ReceiveResponse();
                    Console.WriteLine($"Response: {response}");
                    NetworkClient.CloseConnection();

                    dynamic parsedResponse = JsonConvert.DeserializeObject(response);
                    int transaction_outcome = parsedResponse.transaction_outcome;

                    // checks if the balance is there to withdraw
                    if (transaction_outcome == 0)
                    {
                        MessageBox.Show($"You have successfully withdrawn £{amount}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        SelectTransactionForm cardForm = new SelectTransactionForm(); // instance of select_transaction_form
                        cardForm.Show();
                        this.Close();  // terminates this form
                    }
                    else
                    {
                        // if not enough funds
                        MessageBox.Show("An error occurred!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"error in network operations: {ex.Message}");
                }
                
            }
            else
            {
                // must be a valid number and a multiple of 5
                MessageBox.Show("Please enter a valid withdrawal amount (multiple of 5).", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                amount_txtbox.Text = "£";
            }

        }

        private void BtnNClick(object sender, EventArgs e)
        {
            amount_txtbox.Text = "£";
        }

        private void ExitbtnClick(object sender, EventArgs e)
        {
            SelectTransactionForm cardForm = new SelectTransactionForm(); // instance of select_transaction_form
            cardForm.Show();
            this.Close();  // terminates this form
        }

        private void AmounttxtboxTextChanged(object sender, EventArgs e)
        {

        }

    }
}
