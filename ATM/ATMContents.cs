using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ATM_forms
{
    internal class ATMContents
    {
        // Total sum of all notes in ATM
        public static decimal totalInATM;

        public static decimal GetTotalInATM
        {
            get { return (fivePoundNotes * 5) + (tenPoundNotes * 10) + (twentyPoundNotes * 20) + (fiftyPoundNotes * 50); }
        }

        // number of five pound notes in ATM
        public static decimal fivePoundNotes = 80;

        // number of ten pound notes in ATM
        public static decimal tenPoundNotes = 20;

        // number of twenty pound notes in ATM
        public static decimal twentyPoundNotes = 10;

        // number of fifty pound notes in ATM
        public static decimal fiftyPoundNotes = 4;




        // Remove amountToDispense from ATM selecting lowest number of notes possible
        public static void WithdrawCash(decimal amountToDispense)
        {
            // withdraw as many 50s as possible
            while (amountToDispense >= 50 && fiftyPoundNotes > 0)
            {
                --fiftyPoundNotes;
                amountToDispense -= 50;
            }

            // withdraw as many 20s as possible
            while (amountToDispense >= 20 && twentyPoundNotes > 0)
            {
                --twentyPoundNotes;
                amountToDispense -= 20;
            }

            // withdraw as many 10s as possible
            while (amountToDispense >= 10 && tenPoundNotes > 0)
            {
                --tenPoundNotes;
                amountToDispense -= 10;
            }

            // withdraw as many 5s as possible
            while (amountToDispense >= 5 && fivePoundNotes > 0)
            {
                --fivePoundNotes;
                amountToDispense -= 5;
            }
        }

        // Check ATM has configuration of notes which is capable of withdrawing amountToDispense
        // e.g it is not enough to say ATM has £100 and amountToDispense is £70 so it can be done
        // because what if the £100 is 2x£50.
        public static bool CanWithdrawCash(decimal amountToDispense)
        {
            int fiftyCounter = 0;
            int twentyCounter = 0;
            int tenCounter = 0;
            int fiveCounter = 0;

            // withdraw as many 50s as possible
            while (amountToDispense >= 50 && fiftyCounter < fiftyPoundNotes)
            {
                fiftyCounter++;
                amountToDispense -= 50;
            }

            // withdraw as many 20s as possible
            while (amountToDispense >= 20 && twentyCounter < twentyPoundNotes)
            {
                twentyCounter++;
                amountToDispense -= 20;
            }

            // withdraw as many 10s as possible
            while (amountToDispense >= 10 && tenCounter < tenPoundNotes)
            {
                tenCounter++;
                amountToDispense -= 10;
            }

            // withdraw as many 5s as possible
            while (amountToDispense >= 5 && fiveCounter < fivePoundNotes)
            {
                fiveCounter++;
                amountToDispense -= 5;
            }

            // if amount to dispense is not 0 then 
            if (amountToDispense != 0)
            {
                return false;
            }

            return true;
        }
    }
}
