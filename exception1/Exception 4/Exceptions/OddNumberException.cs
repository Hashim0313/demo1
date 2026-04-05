using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_4.Exceptions
{
    public class OddNumberException : ApplicationException
    {
        public OddNumberException(string message) : base (message)
        {

        }
    }
}
