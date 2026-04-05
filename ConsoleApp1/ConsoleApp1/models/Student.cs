using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.models
{
    public class Student
    {
        public int Id;
        public string Name;
        public string Mark;


        public Student(int id, string name, string mark)
        {
            Id = id;
            Name = name;
            Mark = mark;
        }


        public void Print()
        {
            Console.WriteLine($" Id : {Id}\n name : {Name}\n Mark : {Mark}\n\n");
        }
    }
}
