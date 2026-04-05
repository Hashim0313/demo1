using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_3.Exception
{
    public class AgeException : ApplicationException
    {
        public AgeException (string message) : base (message)
        {

        }
    }
}
