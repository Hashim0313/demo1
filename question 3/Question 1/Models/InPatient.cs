using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1.Models
{
    public class InPatient : Patient
    {
       
        public InPatient(int patientid,string name) : base(patientid,name)
        {
            
        }

        public void CalculateBill(int daysAdmitted)
        {
            int Totalbill = daysAdmitted * 200;

            Console.WriteLine($"Patient id {PatientId} \n Name : {Name} \n days admitted : {daysAdmitted} \n total bill = {Totalbill}");

        }
    }
}
