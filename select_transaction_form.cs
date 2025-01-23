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
            BalanceForm cardForm = new BalanceForm(); // instance of balance_for
            cardForm.Show();
            this.Close();  // terminates this form
        }

        private void CashWithdrawalbtnClick(object sender, EventArgs e)
        {
            WithdrawForm cardForm = new WithdrawForm(); // instance of withdraw_form
            cardForm.Show();
            this.Close();  // terminates this form
        }
    }
}
