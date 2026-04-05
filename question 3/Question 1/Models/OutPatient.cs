using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1.Models
{
    public class OutPatient : Patient
    {
        

        public OutPatient(int patientid, string name) : base(patientid, name)
        {
            
        }

        public void CalculateBill(int visit)
        {
            int totalbill = visit * 50;

            Console.WriteLine($"Patient id {PatientId} \n Name : {Name} \n times visited : {visit} \n total bill = {totalbill}");
        }
    }
}
