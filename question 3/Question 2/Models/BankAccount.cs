using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_2.Models
{
    public class BankAccount
    {
        public int AccountNumber;
        public string HolderName;

        public BankAccount(int accountnumber,string holdername)
        {
            AccountNumber = accountnumber;
            HolderName = holdername;
        }

        public void CalculateInterest(double balance)
        {

        }
    }
}
