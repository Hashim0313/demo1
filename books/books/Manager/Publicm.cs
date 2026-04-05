using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using books.Repository;
using books.Models;
using books.Inteface;
using books.Enums;

namespace books.Manager
{
    public class Publicm 
    {
        UserRepository Publicma = new UserRepository();

        public User loguser;
        public void DisplayMenu()
        {
            Console.WriteLine("Choose an option \n 1 : Register \n 2 : Login ");

            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    Publicma.Register();

                    DisplayMenu();
                    break;

                case "2":
                    loguser = Publicma.Login();
                    if (loguser.Roles == Role.Librarian)
                    {
                        LibraryManager man = new LibraryManager();
                        man.Display();
                        
                    }

                    else if (loguser.Roles == Role.Student)
                    {
                        Student man1 = new Student();
                        man1.Displaystudent();
                    }
                    break;
            }
        }
    }
}
