using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
                    // connect and send response in json format
                    NetworkClient.ConnectToSwitch(TransactionData.connectionAddress, 8885);
                    Console.WriteLine(amount);
                    NetworkClient.SendRequest("{\"request_type\": \"" + TransactionData.transactionType + "\", \"atm_id\":\"" + TransactionData.ATMID + "\", \"pan_number\":\"" + TransactionData.currentPAN + "\",\"pin\":\"" + TransactionData.PIN + "\", \"transaction_value\": \"" + amount + "\"}");
                    //NetworkClient.SendRequest("{\"request_type\": \""+TransactionData.transactionType+"\", \"atm_id\":\"" + TransactionData.ATMID + "\", \"pan_number\":\"" + TransactionData.PAN + "\", \"transaction_value\": \""+amount+"\"}");
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

                    //int transaction_outcome = 0; //for testing

                    switch (transaction_outcome)
                    {
                        case 0: // success

                            if (GlobalVariables.language == "english")
                            {
                                message = $"You have successfully withdrawn £{amount}.";
                                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (GlobalVariables.language == "french")
                            {
                                message = $"Vous avez réussi votre retrait £{amount}.";
                                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else if (GlobalVariables.language == "spanish")
                            {
                                message = $"Has retirado con éxito £{amount}.";
                                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                            SelectTransactionForm cardForm = new SelectTransactionForm();
                            cardForm.Show();
                            this.Close();
                            break;

                        case 1: // insufficient funds
                            string reason = parsedResponse.reason ?? "Insufficient funds.";
                            if (reason == "Insufficient funds." && GlobalVariables.language == "french")
                            {
                                reason = "Fonds insuffisants";
                            }
                            else if (reason == "Insufficient funds." && GlobalVariables.language == "spanish")
                            {
                                reason = "Fondos insuficientes";
                            }
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
                            //decimal closest_amount = 100; // test data
                            // display the message with closest value
                            if (GlobalVariables.language == "french")
                            {
                                message = $"Échec de la transaction: {reason}. \nLe maximum que vous pouvez retirer est £{closest_amount}";
                                alertMessageForm = new AlertMessageForm(message);
                                alertMessageForm.Show(this);
                            }
                            else if (GlobalVariables.language == "english")
                            {
                                message = $"Transaction failed: {reason}. \nThe maximum you can withdraw is £{closest_amount}";
                                alertMessageForm = new AlertMessageForm(message);
                                alertMessageForm.Show(this);
                            }
                            else if (GlobalVariables.language == "spanish")
                            {
                                message = $"La transacción falló: {reason}. \nLo máximo que puedes retirar es £{closest_amount}";
                                alertMessageForm = new AlertMessageForm(message);
                                alertMessageForm.Show(this);
                            }
                            // update the amount text box with the suggested withdrawal amount
                            amount_txtbox.Text = "£" + closest_amount.ToString();
                            break;

                        case 10: // general error
                            if (GlobalVariables.language == "french")
                            {
                                message = "Une erreur s'est produite lors de la transaction. \nVeuillez réessayer plus tard.";
                                alertMessageForm = new AlertMessageForm(message);
                                alertMessageForm.Show(this);
                            }
                            else if (GlobalVariables.language == "english")
                            {
                                message = "An error occurred during the transaction. Please try again later.";
                                alertMessageForm = new AlertMessageForm(message);
                                alertMessageForm.Show(this);
                            }
                            else if (GlobalVariables.language == "spanish")
                            {
                                message = "Se produjo un error durante la transacción. \nInténtelo de nuevo más tarde.";
                                alertMessageForm = new AlertMessageForm(message);
                                alertMessageForm.Show(this);
                            }
                            break;

                        default: // unknown outcome
                            if(GlobalVariables.language == "french")
                            {
                                message = "Réponse inattendue du serveur";
                                alertMessageForm = new AlertMessageForm(message);
                                alertMessageForm.Show(this);
                            }
                            else if (GlobalVariables.language == "english")
                            {
                                message = "Unexpected response from the server.";
                                alertMessageForm = new AlertMessageForm(message);
                                alertMessageForm.Show(this);
                            }
                            else if (GlobalVariables.language == "spanish")
                            {
                                message = "Respuesta inesperada del servidor.";
                                alertMessageForm = new AlertMessageForm(message);
                                alertMessageForm.Show(this);
                            }

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
                if (GlobalVariables.language == "french")
                {
                    AlertMessageForm alertMessageForm = new AlertMessageForm("Montant Invalide. Veuillez saisir un montant de retrait valide\n(multiple de 5).");
                    alertMessageForm.Show(this);
                }
                else if (GlobalVariables.language == "english")
                {
                    AlertMessageForm alertMessageForm = new AlertMessageForm("Invalid Amount. Please enter a valid withdrawal amount\n(multiple of 5).");
                    alertMessageForm.Show(this);
                }
                else if (GlobalVariables.language == "spanish")
                {
                    AlertMessageForm alertMessageForm = new AlertMessageForm("Monto no válido. Ingrese un monto de retiro válido\n(múltiplo de 5).");
                    alertMessageForm.Show(this);
                }
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


            // translate text and reposition if necessary
            if (GlobalVariables.language == "french")
            {
                this.Text = "Retrait";
                amount_label.Text = "Choissisez le montant de votre retrait: ";
                amount_label.Left = (this.withdraw_panel.Width - amount_label.Width) / 2;

                btnY.Text = "Validation";
                btnY.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                btnN.Text = "Correction";
                btnN.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                btnExit.Text = "Annulation";

            }
            else if (GlobalVariables.language == "english")
            {
                this.Text = "Withdraw";
                amount_label.Text = "Enter the amount you wish to withdraw: ";
                amount_label.Left = (this.withdraw_panel.Width - amount_label.Width) / 2;

                btnY.Text = "Enter";
                btnY.Font = new Font("Segoe UI", 14, FontStyle.Bold);

                btnN.Text = "Clear";
                btnN.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                
                btnExit.Text = "Cancel";
            }
            else if (GlobalVariables.language == "spanish")
            {
                this.Text = "Retiro en efectivo";
                amount_label.Text = "Ingresa el monto que deseas retirar: ";
                amount_label.Left = (this.withdraw_panel.Width - amount_label.Width) / 2;

                btnY.Text = "Continuar";
                btnY.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                btnN.Text = "Corregir";
                btnN.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                btnExit.Text = "Cancelar";
            }
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
