using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise.Exceptions
{
    public class InvalidPasswordException : ApplicationException
    {
        public InvalidPasswordException(string message) : base(message)
        {

        }
    }
}
