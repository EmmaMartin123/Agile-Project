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

        private void BtnYClick(object sender, EventArgs e)
        {

            decimal amount;
            string amountText = amount_txtbox.Text.Replace("£", "").Trim(); // removes the pound sign

            // checks the amount entered is valid - must be a multiple of 5 and a valid number
            if (decimal.TryParse(amountText, out amount) && amount > 0 && amount % 5 == 0)
            {

                // check cash can be withdrawn before sending to switch
                if (!ATMContents.CanWithdrawCash(amount))
                {
                    AlertMessageForm alertMessageForm;
                    alertMessageForm = new AlertMessageForm($"Transaction failed: ATM has insufficient funds");
                    alertMessageForm.ShowDialog(this);

                    amount_txtbox.Text = "£";

                    return;
                }

                // send amount to switch to deal with
                try
                {
                    // check cash can be withdrawn before sending to switch
                    if(!ATMContents.CanWithdrawCash(amount))
                    {
                        MessageBox.Show("ATM has insufficient funds", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        // clear what was in the withdraw box
                        amount_txtbox.Text = "£";
                        return;
                    }

                    // connect and send response in json format
                    NetworkClient.ConnectToSwitch(TransactionData.connectionAddress, 8885);
                    Console.WriteLine(amount);
                    NetworkClient.SendRequest("{\"request_type\": \""+TransactionData.transactionType+"\", \"atm_id\":\"" + TransactionData.ATMID + "\", \"pan_number\":\"" + TransactionData.PAN + "\", \"transaction_value\": \""+amount+"\"}");
                    string response = NetworkClient.ReceiveResponse();
                    Console.WriteLine($"Response: {response}");
                    NetworkClient.CloseConnection();

                    //parse the response
                    dynamic parsedResponse = JsonConvert.DeserializeObject(response);
                    int transaction_outcome = parsedResponse.transaction_outcome;

                    //to store the message displayed to the user
                    string message;

                    AlertMessageForm alertMessageForm; 

                    // handles transaction outcomes
                    switch (transaction_outcome)
                    {
                        case 0: // success
                            // remove the cash from ATM stores after confirmation from user bank
                            ATMContents.WithdrawCash(amount);
                            message = $"You have successfully withdrawn £{amount}.";
                            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            SelectTransactionForm cardForm = new SelectTransactionForm();
                            cardForm.Show();
                            this.Close();
                            break;

                        case 1: // insufficient funds
                            string reason = parsedResponse.reason ?? "Insufficient funds.";
                            message = $"Transaction failed: {reason}";

                            //send balance request
                            TransactionData.transactionType = 1;
                            NetworkClient.ConnectToSwitch(TransactionData.connectionAddress, 8885);
                            NetworkClient.SendRequest("{\"request_type\": \"" + TransactionData.transactionType + "\", \"atm_id\":\"" + TransactionData.ATMID + "\", \"pan_number\":\"" + TransactionData.PAN + "\"}");
                            string balanceResponse = NetworkClient.ReceiveResponse();
                            Console.WriteLine($"Balance Response: {balanceResponse}");
                            NetworkClient.CloseConnection();

                            dynamic balanceParsedResponse = JsonConvert.DeserializeObject(balanceResponse);
                            decimal available_balance = balanceParsedResponse.transaction_value;
                            Console.WriteLine(available_balance);

                            // calculate closest multiple of 5 to the available balance
                            decimal closest_amount = Math.Floor(available_balance / 5) * 5;

                            // display the message with closest value
                            alertMessageForm = new AlertMessageForm($"Transaction failed: {reason}. The maximum you can withdraw is £{closest_amount}");
                            alertMessageForm.Show(this);
                            //MessageBox.Show($"Transaction failed: {reason}. The maximum you can withdraw is £{closest_amount}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            // update the amount text box with the suggested withdrawal amount
                            amount_txtbox.Text = "£" + closest_amount.ToString();
                            break;

                        case 10: // general error
                            message = "An error occurred during the transaction. Please try again later.";
                            alertMessageForm = new AlertMessageForm(message);
                            alertMessageForm.Show(this);
                            //MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;

                        default: // unknown outcome
                            message = "Unexpected response from the server.";
                            alertMessageForm = new AlertMessageForm(message);
                            alertMessageForm.Show(this);
                            //MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
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
                AlertMessageForm alertMessageForm = new AlertMessageForm("Invalid Amount. Please enter a valid withdrawal amount\n(multiple of 5).");
                alertMessageForm.Show(this);
                //MessageBox.Show("Please enter a valid withdrawal amount (multiple of 5).", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void WithdrawForm_Load(object sender, EventArgs e)
        {
            // make the form invisible while loading so that it doesn't lag 
            this.Visible = false;
            // center the main panel
            withdraw_panel.Left = (this.ClientSize.Width - withdraw_panel.Width) / 2;
            withdraw_panel.Top = (this.ClientSize.Height - withdraw_panel.Height) / 2;
            // add an event handler to handle resizing
            this.SizeChanged += new EventHandler(this.Withdraw_SizeChanged);
            this.Visible = true; // make form visible again
        }

        /*
        * Event handler to continue to center the panel even if the size changes
        */
        private void Withdraw_SizeChanged(object sender, System.EventArgs e)
        {
            withdraw_panel.Left = (this.ClientSize.Width - withdraw_panel.Width) / 2;
            withdraw_panel.Top = (this.ClientSize.Height - withdraw_panel.Height) / 2;
        }

        private void withdraw_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
