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
                if (GlobalVariables.language == "french")
                {
                    AlertMessageForm alertMessage = new AlertMessageForm("Code PIN invalide. Veuillez saisir un code PIN à 4 chiffres.");
                    alertMessage.Show(this);
                }
                else if (GlobalVariables.language == "english")
                {
                    AlertMessageForm alertMessage = new AlertMessageForm("Invalid PIN. Please enter a 4-digit PIN.");
                    alertMessage.Show(this);
                }
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
            // make the form invisible while loading so that it doesn't lag 
            this.Visible = false;
            // center the main panel
            enter_pin_panel.Left = (this.ClientSize.Width - enter_pin_panel.Width) / 2;
            enter_pin_panel.Top = (this.ClientSize.Height - enter_pin_panel.Height) / 2;
            // add an event handler to handle resizing
            this.SizeChanged += new EventHandler(this.EnterPin_SizeChanged);
            this.Visible = true; // make form visible again

            // change language of text, and resize, and dynamically move to fit 
            if (GlobalVariables.language == "french")
            {
                pin_prompt.Text = "Entrez le code PIN et appuyez sur la touche Validation";
                pin_prompt.Font = new Font("Segoe UI", 25, FontStyle.Bold);
                pin_prompt.Left = (enter_pin_panel.Width - pin_prompt.Width) / 2;

                EnterButton.Text = "Validation";
                EnterButton.Font = new Font("Segoe UI", 8, FontStyle.Bold);

                delete_btn.Text = "Correction";
                delete_btn.Font = new Font("Segoe UI", 8, FontStyle.Bold);

                exit_btn.Text = "Annulation";
            }
            else if (GlobalVariables.language == "english")
            {
                pin_prompt.Text = "Enter PIN and Press ENTER Key";
                pin_prompt.Font = new Font("Segoe UI", 36, FontStyle.Bold);
                pin_prompt.Left = (enter_pin_panel.Width - pin_prompt.Width) / 2;

                EnterButton.Text = "Enter";
                EnterButton.Font = new Font("Segoe UI", 14, FontStyle.Bold);

                delete_btn.Text = "Clear";
                delete_btn.Font = new Font("Segoe UI", 14, FontStyle.Bold);

                exit_btn.Text = "Cancel";
            }
        }

        /*
         * Event handler to continue to center the panel even if the size changes
         */
        private void EnterPin_SizeChanged(object sender, System.EventArgs e)
        {
            enter_pin_panel.Left = (this.ClientSize.Width - enter_pin_panel.Width) / 2;
            enter_pin_panel.Top = (this.ClientSize.Height - enter_pin_panel.Height) / 2;
        }

        private void EnterButtonClick(object sender, EventArgs e)
        {
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

                        int transaction_outcome = 1; // for testing only

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
                            if (GlobalVariables.language == "french")
                            {
                                AlertMessageForm alertMessageForm = new AlertMessageForm("Code PIN invalide. Veuillez réessayer.");
                                alertMessageForm.Show(this);
                            }
                            else if (GlobalVariables.language == "english")
                            {
                                AlertMessageForm alertMessageForm = new AlertMessageForm("Invalid PIN. Please try again.");
                                alertMessageForm.Show(this);
                            }
                           
                            //MessageBox.Show("Incorrect PIN. Please try again.", "Invalid PIN", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    if (GlobalVariables.language == "french")
                    {
                        AlertMessageForm alertMessage = new AlertMessageForm("Code PIN invalide. Veuillez saisir un code PIN à 4 chiffres.");
                        alertMessage.Show(this);
                    }
                    else if (GlobalVariables.language == "english")
                    {
                        AlertMessageForm alertMessage = new AlertMessageForm("Invalid PIN. Please enter a 4-digit PIN.");
                        alertMessage.Show(this);
                    }
                }
            }
            else
            {
                // if the PIN is not exactly 4 digits
                if (GlobalVariables.language == "french")
                {
                    AlertMessageForm alertMessage = new AlertMessageForm("Code PIN invalide. Veuillez saisir un code PIN à 4 chiffres.");
                    alertMessage.Show(this);
                }
                else if (GlobalVariables.language == "english")
                {
                    AlertMessageForm alertMessage = new AlertMessageForm("Invalid PIN. Please enter a 4-digit PIN.");
                    alertMessage.Show(this);
                }
            }
        }

        private void enter_pin_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
