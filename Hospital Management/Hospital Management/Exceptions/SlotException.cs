using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management.Exceptions
{
    public class SlotException : ApplicationException
    {
        public SlotException (string message) : base (message)
        {

        }
    }
}
