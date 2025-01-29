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
            // make the form invisible while loading so that it doesn't lag 
            this.Visible = false;
            insert_card_panel.Left = (this.ClientSize.Width - insert_card_panel.Width) / 2;
            insert_card_panel.Top = (this.ClientSize.Height - insert_card_panel.Height) / 2;
            // add an event handler to handle resizing
            this.SizeChanged += new EventHandler(this.InsertCard_SizeChanged);
            this.Visible = true; // make form visible again
            if (GlobalVariables.language == "french")
            {
                this.Text = "Insérer la Carte";
                insert_card_label.Text = "Insérer la Carte";
            }
            else if (GlobalVariables.language == "english")
            {
                this.Text = "Insert Card";
                insert_card_label.Text = "Insert Card";
            }
            
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
    }
}
