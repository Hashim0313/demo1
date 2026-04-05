using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_2.models
{
    internal class patient
    {

        public int PatientId;
        public string Name;
        public String Disease;


        public void ShowDetails()
        {
            Console.WriteLine($"patient id; {PatientId}, name: {Name} disease {Disease}");
        }

        public patient (int id, string name, string disease)
        {
            PatientId = id;
            Name = name;
            Disease = disease;

        }


    }
}
