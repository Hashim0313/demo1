using bankaccountException.exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccountException.models
{
    public class BankAccount
    {
        public int Balance; 
        

        public BankAccount(int Balance)
        {
            this.Balance = Balance;
            
        }

        public void Withdraw(int amount)
        {
            if (amount == 0 )
            {
                Environment.Exit(0);
            }
            else if (amount > Balance)
            {
                
                throw new InsufficientFundsException ("Insufficient funds for this withdrawal.");
            }

            else if (amount < 0)
            {
                throw new InvalidAmountException("Withdrawal amount must be positive.");
            }
            Balance = Balance-amount;



        }

       
    }
}
