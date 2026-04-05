using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace application_exception.Exception
{
    internal class InvalidEmailExcp : ApplicationException
    {
        public InvalidEmailExcp(string message) : base (message) { }
    }
}
