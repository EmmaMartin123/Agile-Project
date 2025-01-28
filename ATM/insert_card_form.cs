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

        private void insert_card_label_Click(object sender, EventArgs e)
        {

        }

        private void mastercardbtn_Click(object sender, EventArgs e)
        {
            TransactionData.cardType = "mastercard";
            EnterPinForm enterPinForm = new EnterPinForm();  // instance of the enter_pin_form
            enterPinForm.Show();
            this.Hide();
        }

        private void visabtn_Click(object sender, EventArgs e)
        {
            TransactionData.cardType = "visa";
            EnterPinForm enterPinForm = new EnterPinForm();  // instance of the enter_pin_form
            enterPinForm.Show();
            this.Hide();
        }

        private void unionpaybtn_Click(object sender, EventArgs e)
        {
            TransactionData.cardType = "unionpay";
            EnterPinForm enterPinForm = new EnterPinForm();  // instance of the enter_pin_form
            enterPinForm.Show();
            this.Hide();
        }

        private void amexbtn_Click(object sender, EventArgs e)
        {
            TransactionData.cardType = "amex";
            EnterPinForm enterPinForm = new EnterPinForm();  // instance of the enter_pin_form
            enterPinForm.Show();
            this.Hide();
        }
    }
}
