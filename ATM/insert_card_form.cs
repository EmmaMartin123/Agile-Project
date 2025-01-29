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
