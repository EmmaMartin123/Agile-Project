using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_forms
{
    internal class ATMContents
    {
        // Total sum of all notes in ATM
        public static int totalInATM;

        public static int getTotalInATM
        {
            get { return (fivePoundNotes * 5) + (tenPoundNotes * 10) + (twentyPoundNotes * 20) + (fiftyPoundNotes * 50); }
        }

        // number of five pound notes in ATM
        public static int fivePoundNotes = 80;

        // number of ten pound notes in ATM
        public static int tenPoundNotes = 20;

        // number of twenty pound notes in ATM
        public static int twentyPoundNotes = 10;

        // number of fifty pound notes in ATM
        public static int fiftyPoundNotes = 4;
    }
}