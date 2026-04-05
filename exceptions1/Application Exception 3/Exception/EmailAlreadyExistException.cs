using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Exception_3.Exception
{
    internal class EmailAlreadyExistException : ApplicationException
    {
        public EmailAlreadyExistException() 
        {
        }

        public EmailAlreadyExistException(string message) : base(message)
        {
        }
    }
}
