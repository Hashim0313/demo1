using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2.Models
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount (int AccountNumber,string HolderName) : base (AccountNumber, HolderName)
        {

        }

        public void CalculateInterest(double balance)
        {
            double interest = balance * 5 / 100;

            double totalinterest = balance + interest;

            Console.WriteLine($"Account number : {AccountNumber} \n  Holder name : {HolderName} \n balance : {balance} \n interst rate : 5% \n final Balance : {totalinterest} ");
        }

    }
}
