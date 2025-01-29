using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace ATM_forms
{
    public partial class InsertCardForm : Form
    {
        public InsertCardForm()
        {
            InitializeComponent(); 
        }

        private void InsertCardFormLoad(object sender, EventArgs e)
        {
            // make the form invisible while loading so that it doesn't lag 
            this.Visible = false;
            insert_card_panel.Left = (this.ClientSize.Width - insert_card_panel.Width) / 2;
            insert_card_panel.Top = (this.ClientSize.Height - insert_card_panel.Height) / 2;
            // add an event handler to handle resizing
            this.SizeChanged += new EventHandler(this.InsertCard_SizeChanged);
            this.Visible = true; // make form visible again

            // this is just test data and an example of how to use the alert form
            //AlertMessageForm alertMessageForm = new AlertMessageForm("this is a longer error for testing");
            //alertMessageForm.Show(this);
        }

        /*
         * Event handler to continue to center the panel even if the size changes
         */
        private void InsertCard_SizeChanged(object sender, System.EventArgs e)
        {
            insert_card_panel.Left = (this.ClientSize.Width - insert_card_panel.Width) / 2;
            insert_card_panel.Top = (this.ClientSize.Height - insert_card_panel.Height) / 2;
        }

        private void InsertcardpictureboxClick(object sender, EventArgs e)
        {
            EnterPinForm enterPinForm = new EnterPinForm();  // instance of the enter_pin_form
            enterPinForm.Show();
            this.Hide();


        }

        private void MastercardbtnClick(object sender, EventArgs e)
        {
            TransactionData.currentCardType = "mastercard";
            TransactionData.currentPAN = TransactionData.mastercardPAN;
            EnterPinForm enterPinForm = new EnterPinForm();  // instance of the enter_pin_form
            enterPinForm.Show();
            this.Hide();
        }

        private void VisabtnClick(object sender, EventArgs e)
        {
            TransactionData.currentCardType = "visa";
            TransactionData.currentPAN = TransactionData.visaPAN;
            EnterPinForm enterPinForm = new EnterPinForm();  // instance of the enter_pin_form
            enterPinForm.Show();
            this.Hide();
        }

        private void UnionpaybtnClick(object sender, EventArgs e)
        {
            TransactionData.currentCardType = "unionpay";
            TransactionData.currentPAN = TransactionData.unionpayPAN;
            EnterPinForm enterPinForm = new EnterPinForm();  // instance of the enter_pin_form
            enterPinForm.Show();
            this.Hide();
        }

        private void AmexbtnClick(object sender, EventArgs e)
        {
            TransactionData.currentCardType = "amex";
            TransactionData.currentPAN = TransactionData.amexPAN;
            EnterPinForm enterPinForm = new EnterPinForm();  // instance of the enter_pin_form
            enterPinForm.Show();
            this.Hide();
        }
    }
}
