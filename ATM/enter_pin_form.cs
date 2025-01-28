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
    public partial class EnterPinForm : Form
    {
        public EnterPinForm()
        {
            InitializeComponent();

        }

        private void PintxtboxKeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void PinTxtboxTextChanged(object sender, EventArgs e)
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

        /*private void pin_txt_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            // allows only numeric characters
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }*/

        private void DeletebtnClick(object sender, EventArgs e)
        {
            if (pin_txt_box.Text.Length > 0)
            {
                // removes the last character from the pin_txt_box
                pin_txt_box.Text = pin_txt_box.Text.Substring(0, pin_txt_box.Text.Length - 1);
            }

        }

        private void NumberbtnClick(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                pin_txt_box.Text += button.Text; // appends the text to the textBox
            }
        }

        private void ExitbtnClick(object sender, EventArgs e)
        {
            Program.ShowInsertCardForm(this);

        }

        private void ContinuebtnClick(object sender, EventArgs e)
        {
            
        }

        private void EnterPinForm_Load(object sender, EventArgs e)
        {

        }

        private void EnterButtonClick(object sender, EventArgs e)
        {
            Console.WriteLine("continuing");

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
                        /*NetworkClient.ConnectToSwitch(TransactionData.connectionAddress, 8885);
                        NetworkClient.SendRequest("{\"request_type\": \""+TransactionData.transactionType +"\", \"atm_id\":\"" + TransactionData.ATMID + "\", \"pan_number\":\"" + TransactionData.PAN + "\",\"pin\":\"" + TransactionData.PIN + "\"}");
                        string response = NetworkClient.ReceiveResponse();
                        Console.WriteLine($"Response: {response}");
                        NetworkClient.CloseConnection();

                        dynamic parsedResponse = JsonConvert.DeserializeObject(response);
                        int transaction_outcome = parsedResponse.transaction_outcome;*/

                        // assume the response is true for now and set it manually

                        int transaction_outcome = 0; // for testing only

                        if (transaction_outcome == 0)
                        {
                            Console.WriteLine("transaction was successful");
                            // if the PIN matches then proceed
                            SelectTransactionForm cardForm = new SelectTransactionForm(); // instance of select_transaction_form
                            cardForm.Show();
                            this.Close();
                        }
                        else
                        {
                            // if the PIN does not match
                            //string reason = parsedResponse.reason;
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
