using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacy_Management.Interface
{
    public interface IMedicine
    {
        public void AddMedicine();
        public void RemoveMedicine();
        public void DisplayAllMedicine();
        public void PlaceOrder();
        public void CancelOrder();
    }
}
