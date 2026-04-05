using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1.Models
{
    public class Patient
    {
        public int PatientId;
        public string Name;

        public Patient(int patientid,string name)
        {
            PatientId = patientid;
            Name = name;
        }

        public void CalculateBill(int daysAdmitted)
        {

        }
    }
}
