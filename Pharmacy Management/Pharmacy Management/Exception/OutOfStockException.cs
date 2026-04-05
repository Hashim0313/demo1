using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management.Exception
{
    public class OutOfStockException : ApplicationException
    {
        public OutOfStockException(string message) : base (message)
        {

        }
    }
}
