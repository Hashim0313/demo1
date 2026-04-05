using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using books.Inteface;
using books.Models;
using books.Enums;
using books.Manager;

namespace books.Repository
{
    public class UserRepository : IUserRepository
    {
        public static List<User> users = new List<User>();

        public BookManager book55 = new BookManager();

        public User loggeduser;


        public void Register()
        {
            Console.WriteLine("enter Id");
             int Id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter name");
            string Name = Console.ReadLine();

            Role Roles = Role.Librarian;
            Console.WriteLine("Choose role \n 1 : Librarian \n 2 : Student");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Roles = Role.Librarian;
                    break;
                case 2:
                    Roles = Role.Student;
                    break;
            }

            Console.WriteLine("Password");
            string Password = Console.ReadLine();

            Console.WriteLine("\n\n");

            users.Add(new User(Id, Name, Roles,Password));
        }




        public User Login()
        {
            Console.WriteLine("enter Name");
            string name = Console.ReadLine();

            Console.WriteLine("enter Password");
            string password = Console.ReadLine();

            foreach(var u in users)
            {
                if (u.Name == name && u.Password == password)
                {
                    loggeduser = u;

                    Console.WriteLine("Login successfull");
                    return u;
                }
                else
                {
                    Console.WriteLine("invalid credentials");
                }
            }
            return loggeduser;
        }
    }
}
