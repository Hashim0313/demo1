using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_5.models
{
    internal class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public int Balance;

        public int Damount;

        public void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {AccountNumber}\nHolder Name: {HolderName}\nBalance: {Balance}\n");
        }


        public BankAccount(int accountNumber, string holderName, int balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;



        }


        public void Deposit()
        {
             Balance = (Balance) + (Damount);
        }


    }
}
