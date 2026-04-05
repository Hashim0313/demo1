using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Models
{
    internal class JOB
    {
        public int id;
        public string name;
        public string category;
        public int salary;

        public void DisplayInfo()
        {
            Console.WriteLine($"Job ID: {id}");
            Console.WriteLine($"Job Name: {name}");
            Console.WriteLine($"Category: {category}");
            Console.WriteLine($"Salary: {salary}");
        }

    }
}
