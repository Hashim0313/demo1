using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_7.models
{
    public class Employee
    {
        public int EmpId;
        public string Name;
        public int BasicSalary;

        public int NetSalary;


        public void CalculateSalary()
        {
            NetSalary = BasicSalary +(BasicSalary *20/100) - (BasicSalary *10 / 100);

            Console.WriteLine($"employee id : {EmpId} \nname : {Name} \nsalary : {BasicSalary} \nnet salary : {NetSalary}");

        }


       public Employee (int empid, string name, int basicsalary)
        {
            EmpId = empid;
            Name = name;
            BasicSalary = basicsalary;
            
        }


    }
}
