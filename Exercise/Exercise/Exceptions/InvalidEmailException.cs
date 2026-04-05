using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exceptions
{
    public class InvalidEmailException : ApplicationException
    {
       public InvalidEmailException(string message) : base (message)
        {

        }
    }
}
