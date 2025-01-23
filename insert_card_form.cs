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
    public partial class insert_card_form : Form
    {
        public insert_card_form()
        {
            InitializeComponent(); 
        }

        private void insert_card_form_Load(object sender, EventArgs e)
        {
          
        }

        private void insert_card_picture_box_Click(object sender, EventArgs e)
        {
            enter_pin_form enterPinForm = new enter_pin_form();  // instance of the enter_pin_form
            enterPinForm.Show();
            this.Hide();


        }
    }
}
