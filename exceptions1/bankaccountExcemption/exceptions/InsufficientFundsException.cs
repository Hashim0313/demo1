using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bankaccountException.exceptions
{
    internal class InsufficientFundsException : ApplicationException
    {

        

        public InsufficientFundsException(string message) : base(message)
        { }
    }
   
}
