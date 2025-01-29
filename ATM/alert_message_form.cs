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
    public partial class AlertMessageForm : Form
    {
        public AlertMessageForm(string errorMessage)
        {
            InitializeComponent();
            alert_label.Text = errorMessage;
            // position text dynamically based on length
            if (alert_label.Width > this.Width)
            {
                alert_label.Font = new Font("Segoe UI", 8, FontStyle.Bold);
            }

            alert_label.Left = (this.ClientSize.Width - alert_label.Width) / 2;

            
            // ok can just stay Ok in french
        }

        private void AlertMessageForm_Load(object sender, EventArgs e)
        {

        }

        private void alert_ok_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
