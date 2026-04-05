using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static.models
{
    public class Student
{

    public string Name;
    public static int Count = 0;

    public Student(string name)
    {
        Name = name;
        Count++;
    }

}

}



