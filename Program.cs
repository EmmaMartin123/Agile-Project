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
            //Form InsertCardForm = new InsertCardForm();
            Application.Run(new InsertCardForm());
        }

        public static void ShowInsertCardForm(Form currentForm)
        {
            InsertCardForm cardForm = new InsertCardForm(); // instance of insert_card_form
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
