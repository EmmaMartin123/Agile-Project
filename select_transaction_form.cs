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
    public partial class SelectTransactionForm : Form
    {
        public SelectTransactionForm()
        {
            InitializeComponent();
        }

        private void ExitbtnClick(object sender, EventArgs e)
        {
            Program.ShowInsertCardForm(this);
        }

        private void CheckBalancebtnClick(object sender, EventArgs e)
        {

            Program.show_insert_card_form(this);
        }

        private void select_transaction_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void check_balance_btn_Click(object sender, EventArgs e)
        {
            TransactionData.transactionType = 1;
            balance_form cardForm = new balance_form(); // instance of balance_form
            cardForm.Show();
            this.Close();  // terminates this form
        }

        private void cash_withdrawal_btn_Click(object sender, EventArgs e)
        { 
            TransactionData.transactionType = 2;
            withdraw_form cardForm = new withdraw_form(); // instance of withdraw_form
            cardForm.Show();
            this.Close();  // terminates this form
        }

        private void select_transaction_label_Click(object sender, EventArgs e)
        {

        }
    }
}
