using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance_2.models
{
    public class Person
    {

        public string? FirstName;
        public string? LastName;
        public int Age;



        public string GetFullName()
        {
            return $"{FirstName} {LastName}";
        }

        public Person()
        {
            FirstName = "James";
            LastName = "Bond";
            Age = 45;
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }
    }


    public class Employee : Person
    {
        public int Id;
        public string? Position;

        public string GetEmployeeInfo()
        {
            return $"ID:{Id} FullName:{FirstName} {LastName} Position:{Position} Age:{Age}";
        }


        public Employee() : base()
        {
            Id = 007;
            Position = "MI6 Agent";
        }

        public Employee(string firstName, string lastName, int age, int id, string position) : base(firstName, lastName, age)
        {
            Id = id;
            Position = position;
        }


    }


}
