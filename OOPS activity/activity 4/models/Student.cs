using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace activity_4.models
{
    public class Student
    {

        public int RollNo;
        public string Name;
        public int Marks;



        public void CheckResult()
        { if (Marks >= 40)
            {
                Console.WriteLine($"name : {Name}\n Roll No : {RollNo}\n mark : {Marks}\n Passed \n");
            }
            else
            {
                Console.WriteLine($"name : {Name}\n Roll No : {RollNo} \n mark : {Marks}\n Failed\n");
            }
        }
    

    public Student(int rollno, string name, int marks)
        {
            RollNo = rollno;
            Name = name;
            Marks = marks;
        }
    }
}
