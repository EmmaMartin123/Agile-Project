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
                // checks if the balance is there to withdraw
                if (TransactionData.CurrentBalance >= amount)
                {
                    TransactionData.CurrentBalance -= amount; // deduct the amount from balance
                    MessageBox.Show($"You have successfully withdrawn £{amount}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    select_transaction_form cardForm = new select_transaction_form(); // instance of select_transaction_form
                    cardForm.Show();
                    this.Close();  // terminates this form
                }
                else
                {
                    // if not enough funds
                    MessageBox.Show("Insufficient balance!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            select_transaction_form cardForm = new select_transaction_form(); // instance of select_transaction_form
            cardForm.Show();
            this.Close();  // terminates this form
        }

        private void amount_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void withdraw_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
