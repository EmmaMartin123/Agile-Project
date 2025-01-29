using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_forms
{
    public partial class PromptForm : Form
    {
        public PromptForm(string title, string message)
        {
            InitializeComponent();
            this.Text = title;
            this.StartPosition = FormStartPosition.CenterScreen; // ensures it starts centered
            prompt_label1.Text = message;
            // position text dynamically based on length
            prompt_label1.Left = (this.ClientSize.Width - prompt_label1.Width) / 2;
        }


        private void YesbtnClick(object sender, EventArgs e)
        {
            // generate a unique ID for the receipt using guid
            string uniqueId = Guid.NewGuid().ToString();

            // get the path to the user's documents folder
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsFolder, $"receipt_{uniqueId}.txt");

            // use streamWriter to write text to the file
            using (StreamWriter writer = new StreamWriter(filePath, true)) 
            {
                writer.WriteLine(prompt_label1.Text); // write the text message to the file
            }

            this.Close(); 
        }

        private void NobtnClick(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void PromptForm_Load(object sender, EventArgs e)
        {
            
        }

        private void prompt_label1_Click(object sender, EventArgs e)
        {

        }
    }
}
