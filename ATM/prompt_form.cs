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

        private decimal withdrawal_amount; // field to store the withdrawal amount

        public PromptForm(string title, string message, decimal amount)
        {
            InitializeComponent();
            this.Text = title;
            this.StartPosition = FormStartPosition.CenterScreen; // ensures it starts centered
            prompt_label1.Text = message;
            // position text dynamically based on length
            prompt_label1.Left = (this.ClientSize.Width - prompt_label1.Width) / 2;
            withdrawal_amount = amount;
        }


        private void YesbtnClick(object sender, EventArgs e)
        {
            // generate a unique ID for the receipt using guid
            string uniqueId = Guid.NewGuid().ToString();

            // get the current date and time 
            string currentDate = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");

            string withdrawalAmount = "";

            if (GlobalVariables.language == "english")
            {
                withdrawalAmount = $"Withdrawal Amount: {withdrawal_amount:C}"; // this will format it as currency ( eg £100.00)

            }
            else if (GlobalVariables.language == "french")
            {
                withdrawalAmount = $"Montant du retrait: {withdrawal_amount:C}"; // this will format it as currency ( eg £100.00)

            }
            else if (GlobalVariables.language == "spanish")
            {
                withdrawalAmount = $"Monto del retiro: {withdrawal_amount:C}"; // this will format it as currency ( eg £100.00)

            }

            // get the path to the user's documents folder
            string documentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(documentsFolder, $"receipt_{uniqueId}.txt");

            // use streamWriter to write text to the file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                if (GlobalVariables.language == "english")
                {
                    // Write the structured receipt content to the file
                    writer.WriteLine("Transaction Receipt");
                    writer.WriteLine("-----------------------");
                    writer.WriteLine($"Date: {currentDate}");
                    writer.WriteLine($"Receipt ID: {uniqueId}");
                    writer.WriteLine(withdrawalAmount);  // Use the transaction data here
                    writer.WriteLine("-----------------------");
                    writer.WriteLine("Thank you for your transaction.");
                }
                else if (GlobalVariables.language == "french")
                {
                    // Write the structured receipt content to the file
                    writer.WriteLine("Reçu de Transaction");
                    writer.WriteLine("-----------------------");
                    writer.WriteLine($"Date: {currentDate}");
                    writer.WriteLine($"ID du reçu: {uniqueId}");
                    writer.WriteLine(withdrawalAmount);  // Use the transaction data here
                    writer.WriteLine("-----------------------");
                    writer.WriteLine("Merci pour votre transaction.");
                }
                else if (GlobalVariables.language == "spanish")
                {
                    // Write the structured receipt content to the file
                    writer.WriteLine("Recibo de Transacción");
                    writer.WriteLine("-----------------------");
                    writer.WriteLine($"Fecha: {currentDate}");
                    writer.WriteLine($"ID de recibo: {uniqueId}");
                    writer.WriteLine(withdrawalAmount);  // Use the transaction data here
                    writer.WriteLine("-----------------------");
                    writer.WriteLine("Gracias por su transacción.");
                }
            }

            this.Close(); 
        }

        private void NobtnClick(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void PromptForm_Load(object sender, EventArgs e)
        {
            if (GlobalVariables.language == "english")
            {
                this.Text = "Success";
                yes_btn.Text = "YES";
                no_btn.Text= "NO";
            }
            else if (GlobalVariables.language == "french")
            {
                this.Text = "Succès";
                yes_btn.Text = "OUI";
                no_btn.Text = "NON";
            }
            else if (GlobalVariables.language == "spanish")
            {
                this.Text = "Éxito";
                yes_btn.Text = "SÍ";
                no_btn.Text = "NO";
            }
        }

        private void prompt_label1_Click(object sender, EventArgs e)
        {

        }

        private void prompt_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
