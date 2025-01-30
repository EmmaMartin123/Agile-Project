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

        private void french_button_Click(object sender, EventArgs e)
        {
            // set language to chosen language, remove chosen language button, add other language buttons
            GlobalVariables.language = "french";
            spanish_button.Visible = false;
            english_button.Visible = false; 
            // move position of english button
            english_button.Top = insert_card_panel.Top - 20;
            spanish_button.Top = english_button.Bottom + 10;

            english_button.Visible = true;
            spanish_button.Visible = true;
            french_button.Visible = false;

            // change things actually on this form
            this.Text = "Insérer la Carte";
            insert_card_label.Text = "Insérer la Carte";

           
        }

        private void spanish_button_Click(object sender, EventArgs e)
        {
            // set language to chosen language, remove chosen language button, add other language buttons
            GlobalVariables.language = "spanish";
            english_button.Top = insert_card_panel.Top-20;
            french_button.Top = english_button.Bottom +10;

            english_button.Visible = true;
            spanish_button.Visible = false;
            french_button.Visible = true;

           
        }

        private void english_button_Click(object sender, EventArgs e)
        {
            // set language to chosen language, remove chosen language button, add other language buttons
            GlobalVariables.language = "english";
            spanish_button.Top = insert_card_panel.Top - 20;
            french_button.Top = spanish_button.Bottom +10;

            english_button.Visible = false;
            spanish_button.Visible = true;
            french_button.Visible = true;

            // change things actually on this form
            this.Text = "Insert Card";
            insert_card_label.Text = "Insert Card";

            
        }

    }
}
