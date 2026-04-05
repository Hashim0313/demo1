using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management.Exceptions
{
    public class DoctorDoesnotExist : ApplicationException
    {
        public DoctorDoesnotExist(string message) : base(message)
        {

        }
    }
}
