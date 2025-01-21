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
            // gets the balance from the TransactionData class
            decimal currentBalance = TransactionData.CurrentBalance;

            balance_label.Text = $"£{currentBalance:F2}"; // F2 for two decimal places
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
