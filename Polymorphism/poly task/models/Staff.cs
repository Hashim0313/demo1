using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poly_task.models
{
    internal class Staff
    {
        public string Name;
        

        public Staff(string name)
        {
            Name = name;
        }
        public virtual double calculateSalary()
        {
            return  0;
        }
    }

    class Doctor : Staff
    {

        
        public Doctor(string name) : base(name)
        {
          
        }
        public override double calculateSalary()
        {
            return 120000;
        }
    }

    class Nurse : Staff
    {
        public Nurse(string name) : base(name)
        {
        }
        public override double calculateSalary()
        {
            return 80000;
        }
    }

    class Receptionist : Staff
    {
        public Receptionist(string name) : base(name)
        {
        }
        public override double calculateSalary()
        {
            return 60000;
        }
    }













}
