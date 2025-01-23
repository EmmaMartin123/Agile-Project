using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM_forms
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form insertCardForm = new insert_card_form();
            Application.Run(new insert_card_form());
        }

        public static void show_insert_card_form(Form currentForm)
        {
            insert_card_form cardForm = new insert_card_form(); // instance of insert_card_form
            cardForm.Show();
            currentForm.Close();  
        }

    }

    public static class TransactionData
    {
        // transaction variables (dummy data for now)
        public static decimal CurrentBalance = 500;
        public static int TransactionID = 1234;
        public static int ATMID = 5678;
        public static string PAN = "2345678901234567";
        public static int PIN = 1234;
    }

}
