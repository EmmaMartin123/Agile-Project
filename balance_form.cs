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
    public partial class BalanceForm : Form
    {
        public BalanceForm()
        {
            InitializeComponent();
        }

        private void BalanceformLoad(object sender, EventArgs e)
        {
            // gets the balance from the TransactionData class
            decimal currentBalance = TransactionData.CurrentBalance;

            balance_label.Text = $"£{currentBalance:F2}"; // F2 for two decimal places
        }

        private void DonebtnClick(object sender, EventArgs e)
        {
            SelectTransactionForm cardForm = new SelectTransactionForm(); // instance of select_transaction_form
            cardForm.Show();
            this.Close();  // terminates this form
        }

        
    }
}
