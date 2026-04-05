using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management.Exception
{
    public class MedicineNotFoundException : ApplicationException
    {
       public MedicineNotFoundException(string message) : base (message)
        {

        }
    }
}
