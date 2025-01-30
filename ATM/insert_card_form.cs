using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
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

            // change language if langauge change is set
            if (GlobalVariables.language == "french")
            {
                this.Text = "Insérer la Carte";
                insert_card_label.Text = "Insérer la Carte";
                insert_card_label.Left = (this.insert_card_panel.Width - insert_card_label.Width) / 2;

                language1_button.Text = "English";
                language1_button.Image = ATM_forms.Properties.Resources.british;

                language2_button.Text = "Español";
                language2_button.Image = ATM_forms.Properties.Resources.spain;

            }
            else if (GlobalVariables.language == "english")
            {
                this.Text = "Insert Card";
                insert_card_label.Text = "Insert Card";
                insert_card_label.Left = (this.insert_card_panel.Width - insert_card_label.Width) / 2;

                language1_button.Text = "Español";
                language1_button.Image = ATM_forms.Properties.Resources.spain;

                language2_button.Text = "Français";
                language2_button.Image = ATM_forms.Properties.Resources.frenchflag;
            }
            else if (GlobalVariables.language == "spanish")
            {
                this.Text = "Introduzca su tarjeta";
                insert_card_label.Text = "Introduzca su tarjeta";
                insert_card_label.Left = (this.insert_card_panel.Width - insert_card_label.Width) / 2;

                language1_button.Text = "English";
                language1_button.Image = ATM_forms.Properties.Resources.british;

                language2_button.Text = "Français";
                language2_button.Image = ATM_forms.Properties.Resources.frenchflag;
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

        private void language1_button_Click(object sender, EventArgs e)
        {
            // get the language that is currently being used
            string currentLanguage = GlobalVariables.language;
            string newLanguage = language1_button.Text;

            // change the buttons based on what the previous language was
            if (currentLanguage == "english")
            {
                language1_button.Text = "English";
                language1_button.Image = ATM_forms.Properties.Resources.british;
            }
            else if (currentLanguage == "french")
            {
                language1_button.Text = "Français";
                language1_button.Image = ATM_forms.Properties.Resources.frenchflag;
            }
            else if (currentLanguage == "spanish")
            {
                language1_button.Text = "Español";
                language1_button.Image = ATM_forms.Properties.Resources.spain;
            }

            // change everything based on the new chosen language
            if (newLanguage == "English")
            {
                GlobalVariables.language = "english";
                this.Text = "Insert Card";
                insert_card_label.Text = "Insert Card";
                insert_card_label.Left = (this.insert_card_panel.Width - insert_card_label.Width) / 2;
            }
            else if (newLanguage == "Français")
            {
                GlobalVariables.language = "french";
                this.Text = "Insérer la Carte";
                insert_card_label.Text = "Insérer la Carte";
                insert_card_label.Left = (this.insert_card_panel.Width - insert_card_label.Width) / 2;
            }
            else if (newLanguage == "Español")
            {
                GlobalVariables.language = "spanish";
                this.Text = "Introduzca su tarjeta";
                insert_card_label.Text = "Introduzca su tarjeta";
                insert_card_label.Left = (this.insert_card_panel.Width - insert_card_label.Width) / 2;
            }
        }

        private void language2_button_Click(object sender, EventArgs e)
        {

            // get the language that is currently being used
            string currentLanguage = GlobalVariables.language;
            string newLanguage = language2_button.Text;

            // change the buttons based on what the previous language was
            if (currentLanguage == "english")
            {
                language2_button.Text = "English";
                language2_button.Image = ATM_forms.Properties.Resources.british;
            }
            else if (currentLanguage == "french")
            {
                language2_button.Text = "Français";
                language2_button.Image = ATM_forms.Properties.Resources.frenchflag;
            }
            else if (currentLanguage == "spanish")
            {
                language2_button.Text = "Español";
                language2_button.Image = ATM_forms.Properties.Resources.spain;
            }

            // change everything based on the new chosen language
            if (newLanguage == "English")
            {
                GlobalVariables.language = "english";
                this.Text = "Insert Card";
                insert_card_label.Text = "Insert Card";
                insert_card_label.Left = (this.insert_card_panel.Width - insert_card_label.Width) / 2;
            }
            else if (newLanguage == "Français")
            {
                GlobalVariables.language = "french";
                this.Text = "Insérer la Carte";
                insert_card_label.Text = "Insérer la Carte";
                insert_card_label.Left = (this.insert_card_panel.Width - insert_card_label.Width) / 2;
            }
            else if (newLanguage == "Español")
            {
                GlobalVariables.language = "spanish";
                this.Text = "Introduzca su tarjeta";
                insert_card_label.Text = "Introduzca su tarjeta";
                insert_card_label.Left = (this.insert_card_panel.Width - insert_card_label.Width) / 2;
            }

        }

        private void insert_card_panel_Paint(object sender, PaintEventArgs e)
        {


            
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
    }
}
