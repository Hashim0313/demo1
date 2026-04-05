using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace books.Manager
{
    public class Student
    {

        public BookManager book33 = new BookManager(); 
        public void Displaystudent()
        {
            Console.WriteLine("choose an option :\n 1 : Get books");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    book33.GetBook();
                    break;

            }
        }
    }
}
