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

            Program.ShowInsertCardForm(this);
        }

        private void select_transaction_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void check_balance_btn_Click(object sender, EventArgs e)
        {
            TransactionData.transactionType = 1;
            BalanceForm cardForm = new BalanceForm(); // instance of balance_form
            cardForm.Show();
            this.Close();  // terminates this form
        }

        private void cash_withdrawal_btn_Click(object sender, EventArgs e)
        { 
            TransactionData.transactionType = 2;
            WithdrawForm cardForm = new WithdrawForm(); // instance of withdraw_form
            cardForm.Show();
            this.Close();  // terminates this form
        }

        private void select_transaction_label_Click(object sender, EventArgs e)
        {

        }

        private void SelectTransactionForm_Load(object sender, EventArgs e)
        {

        }

        private void SelectTransactionForm_Load_1(object sender, EventArgs e)
        {
            // make the form invisible while loading so that it doesn't lag 
            this.Visible = false;
            // center the main panel
            select_transaction_panel.Left = (this.ClientSize.Width - select_transaction_panel.Width) / 2;
            select_transaction_panel.Top = (this.ClientSize.Height - select_transaction_panel.Height) / 2;
            // add an event handler to handle resizing
            this.SizeChanged += new EventHandler(this.SelectTransaction_SizeChanged);
            this.Visible = true; // make form visible again

            // translate text and reposition if necessary
            if (GlobalVariables.language == "french")
            {
                this.Text = "Choisissez votre Opération";
                select_transaction_label.Text = "Choisissez votre Opération";
                select_transaction_label.Left = (this.select_transaction_panel.Width - select_transaction_label.Width) / 2;

                check_balance_btn.Text = "SITUATION DE VOS COMPTES";
                check_balance_btn.Font = new Font("Segoe UI", 22, FontStyle.Bold);

                cash_withdrawal_btn.Text = "RETRAIT D'ARGENT";

                exit_btn.Text = "FIN";
            }
            else if (GlobalVariables.language == "english")
            {
                this.Text = "Select Transaction";
                select_transaction_label.Text = "Select a Transaction";
                select_transaction_label.Left = (this.select_transaction_panel.Width - select_transaction_label.Width) / 2;

                check_balance_btn.Text = "CHECK BALANCE";
                check_balance_btn.Font = new Font("Segoe UI", 26, FontStyle.Bold);

                cash_withdrawal_btn.Text = "CASH WITHDRAWAL";

                exit_btn.Text = "EXIT";
            }
            else if (GlobalVariables.language == "spanish")
            {
                this.Text = "Seleccionar transacción";
                select_transaction_label.Text = "Seleccione una transacción";
                select_transaction_label.Left = (this.select_transaction_panel.Width - select_transaction_label.Width) / 2;

                check_balance_btn.Text = "CONSULTA DE SALDO";
                check_balance_btn.Font = new Font("Segoe UI", 26, FontStyle.Bold);

                cash_withdrawal_btn.Text = "RETIRO EN EFECTIVO";

                exit_btn.Text = "SALIR";
            }
        }

        /*
         * Event handler to continue to center the panel even if the size changes
         */
        private void SelectTransaction_SizeChanged(object sender, System.EventArgs e)
        {
            select_transaction_panel.Left = (this.ClientSize.Width - select_transaction_panel.Width) / 2;
            select_transaction_panel.Top = (this.ClientSize.Height - select_transaction_panel.Height) / 2;
        }


    }
}
