using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_task.models
{
    internal class Patient
    {
        private string Name;
        private int Age;
        private string Disease;


        public Patient(string name, int age, string disease)
        {
            Name = name;
            Age = age;
            Disease = disease;
        }

        public string getName()
        {
            return Name;
        }
        public int getAge()
        {
            return Age;
        }

        public string getDisease()
        {
            return Disease;
        }


    }
}
