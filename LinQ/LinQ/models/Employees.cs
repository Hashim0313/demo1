using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQ.models
{
    public class Employees
    {
        public string Name;
        public string Salary;
        public string Designation;

        public Employees (string Name, string Salary, string Designation)
        {
            this.Name = Name;
            this.Salary = Salary;
            this.Designation = Designation;
        }
    }
}
