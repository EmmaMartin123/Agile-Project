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
    public partial class balance_form : Form
    {
        public balance_form()
        {
            InitializeComponent();
        }

        private void balance_form_Load(object sender, EventArgs e)
        {
            Program.form_load(sender, e);
            // send the pin to the switch to deal with
            try
            {
                // network stuff here
                NetworkClient.ConnectToSwitch("ec2-44-211-248-152.compute-1.amazonaws.com", 8885);
                NetworkClient.SendRequest("{\"request_type\": \"1\", \"atm_id\":\"" + TransactionData.ATMID + "\", \"pan_number\":\"" + TransactionData.PAN + "\"}");
                string response = NetworkClient.ReceiveResponse();
                Console.WriteLine($"Response: {response}");
                NetworkClient.CloseConnection();

                dynamic parsedResponse = JsonConvert.DeserializeObject(response);
                int transaction_value = Int32.Parse(parsedResponse.transaction_value);

                // assume the response is true for now and set it manually
                transaction_value = 500; // for testing only as we can't currently get a response
                balance_label.Text = $"£{transaction_value:F2}"; // F2 for two decimal places
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error in network operations: {ex.Message}");
            }
        }

        private void done_btn_Click(object sender, EventArgs e)
        {
            select_transaction_form cardForm = new select_transaction_form(); // instance of select_transaction_form
            cardForm.Show();
            this.Close();  // terminates this form
        }

        private void balance_label_Click(object sender, EventArgs e)
        {
            
        }

        private void balance_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        
    }
}
