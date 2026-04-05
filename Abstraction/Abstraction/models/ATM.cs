using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.models
{
    public abstract class ATM
    {
        public abstract void WithdrawMoney(decimal amount);
        public abstract void CheckBalance();
        public abstract void DepositMoney(decimal amount);

    }

    public class BankATM : ATM
    {
        private decimal balance;

        public BankATM(decimal initialBalance)
        {
            balance = initialBalance;
        }

        public override void WithdrawMoney(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"you withdrawn {amount:C}.new balance : {balance:C}");
            }

            else
            {
                Console.WriteLine("Insufficient balance or invalid amount.");
            }

        }

        public override void CheckBalance()
        {
            Console.WriteLine($"Current balance: {balance:C}");
        }

        public override void DepositMoney(decimal amount)
        {
          if (amount >0)
            {
                balance += amount;
                Console.WriteLine($"you deposited {amount:C}.new balance : {balance:C}");
            }
          else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

    }

}
