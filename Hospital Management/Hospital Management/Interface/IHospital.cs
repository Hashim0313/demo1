using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_Management.Interface
{
    public interface IHospital
    {
        public  void AddDoctor();

        public  void RemoveDoctor();

        public  void DisplayDoctors();
        public void BookAppointment();
        public void CancelAppointment();
        
    }
}
