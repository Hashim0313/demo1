using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.models
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal initialBalance)
        {
            balance = initialBalance;
        }

      public void Deposit(decimal amount)
      {
        if (amount > 0)
        {
           balance += amount;
           Console.WriteLine($"Deposited: {amount:C}. New balance: {balance}");

        }

        else 
        {

            Console.WriteLine("Deposit amount must be positive.");
        
        }
      }

        public void Withdraw (decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
                return;
            }

            if (amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrew: {amount}. New balance: {balance}");
            }

            else
            {
                Console.WriteLine("Insufficient funds ");
            }
        }

        public decimal GetBalance()
        {
             return balance;
        }

    }
}
