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
    }
}
