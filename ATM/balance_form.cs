using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
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
            // make the form invisible while loading so that it doesn't lag 
            this.Visible = false;
            // center the main panel
            balance_panel.Left = (this.ClientSize.Width - balance_panel.Width) / 2;
            balance_panel.Top = (this.ClientSize.Height - balance_panel.Height) / 2;
            // add an event handler to handle resizing
            this.SizeChanged += new EventHandler(this.Balance_SizeChanged);
            this.Visible = true; // make form visible again

            if (GlobalVariables.language == "french")
            {
                this.Text = " Vérifier le Solde";
                balance_heading_label.Text = "Solde";

                done_btn.Text = "Fin";
            }
            else if (GlobalVariables.language == "english")
            {
                this.Text = "Check Balance";
                balance_heading_label.Text = "Balance";

                done_btn.Text = "Done";
            }
            else if (GlobalVariables.language == "spanish")
            {
                this.Text = "Consultar Saldo";
                balance_heading_label.Text = "Saldo";

                done_btn.Text = "Hecho";
            }


            // send the balance request to the switch to deal with
            try
            {
                // connect and send response in json format

                TransactionData.transactionType = 1;
                NetworkClient.ConnectToSwitch(TransactionData.connectionAddress, 8885);
                NetworkClient.SendRequest("{\"request_type\": \"" + TransactionData.transactionType + "\", \"atm_id\":\"" + TransactionData.ATMID + "\", \"pan_number\":\"" + TransactionData.currentPAN + "\",\"pin\":\"" + TransactionData.PIN + "\"}");


                string response = NetworkClient.ReceiveResponse();
                Console.WriteLine($"Response: {response}");
                NetworkClient.CloseConnection();

                dynamic parsedResponse = JsonConvert.DeserializeObject(response);

                double transaction_value = parsedResponse.transaction_value;
                //int transaction_value = 100; //test data

                balance_label.Text = $"£{transaction_value:F2}"; // F2 for two decimal places
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error in network operations: {ex.Message}");
            }
        }

        /*
         * Event handler to continue to center the panel even if the size changes
         */
        private void Balance_SizeChanged(object sender, System.EventArgs e)
        {
            balance_panel.Left = (this.ClientSize.Width - balance_panel.Width) / 2;
            balance_panel.Top = (this.ClientSize.Height - balance_panel.Height) / 2;
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