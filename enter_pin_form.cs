using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace ATM_forms
{
    public partial class enter_pin_form : Form
    {
        public enter_pin_form()
        {
            InitializeComponent();

        }

        private void enter_pin_form_Load(object sender, EventArgs e)
        {
            Program.form_load(sender, e); 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void enter_pin_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pin_txt_box_TextChanged(object sender, EventArgs e)
        {

            pin_txt_box.PasswordChar = '*';   // hides input 

            // the text is only digits and has a maximum length of 4
            if (!int.TryParse(pin_txt_box.Text, out _) || pin_txt_box.Text.Length > 4)
            {
                MessageBox.Show("Please enter a valid 4-digit PIN.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pin_txt_box.Text = pin_txt_box.Text.Substring(0, Math.Min(4, pin_txt_box.Text.Length));
                pin_txt_box.SelectionStart = pin_txt_box.Text.Length; // moves the cursor to the end
            }

        }

        private void pin_txt_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numeric characters
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {

            if (pin_txt_box.Text.Length > 0)
            {
                // removes the last character from the pin_txt_box
                pin_txt_box.Text = pin_txt_box.Text.Substring(0, pin_txt_box.Text.Length - 1);
            }

        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Program.show_insert_card_form(this);

        }

        private void continue_btn_Click(object sender, EventArgs e)
        {
            //int correctPin = TransactionData.PIN;

            // checks if the PIN is exactly 4 digits 
            if (pin_txt_box.Text.Length == 4)
            {
                if (int.TryParse(pin_txt_box.Text, out int enteredPin))
                {
                    TransactionData.PIN = enteredPin;
                    TransactionData.transactionType = 0;
                    // send the pin to the switch to deal with
                    try
                    {

                        // connect and send response in json format
                        NetworkClient.ConnectToSwitch(TransactionData.connectionAddress, 8885);
                        NetworkClient.SendRequest("{\"request_type\": \""+TransactionData.transactionType +"\", \"atm_id\":\"" + TransactionData.ATMID + "\", \"pan_number\":\"" + TransactionData.PAN + "\",\"pin\":\"" + TransactionData.PIN + "\"}");
                        string response = NetworkClient.ReceiveResponse();
                        Console.WriteLine($"Response: {response}");
                        NetworkClient.CloseConnection();

                        dynamic parsedResponse = JsonConvert.DeserializeObject(response);
                        int transaction_outcome = parsedResponse.transaction_outcome;

                        // assume the response is true for now and set it manually

                        //transaction_outcome en= 0; // for testing only as we can't currently get a response

                        if (transaction_outcome == 0)
                        {
                            // if the PIN matches then proceed
                            select_transaction_form cardForm = new select_transaction_form(); // instance of select_transaction_form
                            cardForm.Show();
                            this.Close();
                        }
                        else
                        {
                            // if the PIN does not match
                            string reason = parsedResponse.reason;
                            MessageBox.Show("Incorrect PIN. Please try again.", "Invalid PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            pin_txt_box.Clear();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"error in network operations: {ex.Message}");
                    }
                }
                else
                {
                    // if the entered PIN is not a valid integer
                    MessageBox.Show("Please enter a valid 4-digit PIN.", "Invalid PIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                // if the PIN is not exactly 4 digits
                MessageBox.Show("Please enter a 4-digit PIN.", "Invalid PIN", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
