using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using books.Models;
using books.Inteface;
using books.Enums;
using books.Repository;
using books.Manager;

namespace books.Manager
{
    public class LibraryManager : ILibrary
    {
       

        public BookManager managebook = new BookManager();

        public Publicm manage2 = new Publicm();

        public void Display()
        {
            Console.WriteLine("Choose an option \n 1 : Add book \n 2 : Get book \n 3 : logout");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    managebook.AddBook();
                    Display();
                    break;

                case "2":
                    managebook.GetBook();
                    Display();
                    break;
                case "3":
                  manage2.DisplayMenu();
                    break;
            }
        }

       
    }
}
