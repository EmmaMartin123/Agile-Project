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
    public partial class withdraw_form : Form
    {
        public withdraw_form()
        {
            InitializeComponent();
        }

        private void withdraw_form_Load(object sender, EventArgs e)
        {
            Program.form_load(sender, e);
        }

        // single event handler for all number buttons
        private void NumberButton_Click(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                amount_txtbox.Text += button.Text; // appends the text to the textBox
            }
        }

        // prevents keypress for amount_txtbox
        private void amount_txtbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true; 
        }

        private void btnY_Click(object sender, EventArgs e)
        {

            decimal amount;
            string amountText = amount_txtbox.Text.Replace("£", "").Trim(); // removes the pound sign

            // checks the amount entered is valid - must be a multiple of 5 and a valid number
            if (decimal.TryParse(amountText, out amount) && amount > 0 && amount % 5 == 0)
            {
                try
                {
                    // network stuff here
                    NetworkClient.ConnectToSwitch("ec2-44-211-248-152.compute-1.amazonaws.com", 8885);
                    NetworkClient.SendRequest("{\"request_type\": \"2\", \"atm_id\":\"" + TransactionData.ATMID + "\", \"pan_number\":\"" + TransactionData.PAN + "\", \"transaction_value\": \"" + amount + "\"}");
                    string response = NetworkClient.ReceiveResponse();
                    Console.WriteLine($"Response: {response}");
                    NetworkClient.CloseConnection();

                    dynamic parsedResponse = JsonConvert.DeserializeObject(response);
                    int transaction_outcome = Int32.Parse(parsedResponse.transaction_outcome);

                    // assume the response is true for now and set it manually
                    transaction_outcome = 0; // for testing only as we can't currently get a response

                    // checks if the balance is there to withdraw
                    if (transaction_outcome == 0)
                    {
                        MessageBox.Show($"You have successfully withdrawn £{amount}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        select_transaction_form cardForm = new select_transaction_form(); // instance of select_transaction_form
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

        private void btnN_Click(object sender, EventArgs e)
        {
            amount_txtbox.Text = "£";
        }

        private void amount_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void withdraw_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
