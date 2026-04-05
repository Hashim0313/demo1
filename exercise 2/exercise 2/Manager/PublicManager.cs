using exercise_2.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exercise_2.models;
using exercise_2.Manager;
using exercise_2.Enums;

namespace exercise_2.Manager
{
    public class PublicManager : ILogin, IMenu
    {
        private User[] users = new User[5];
        private int usercount = 0;

        private readonly JobManager jobManager;

        public PublicManager(JobManager jobManager)
        {
            jobManager = jobManager;
        }

        public bool Login(string email, string password)
        {
            for (int i = 0; i < users.Length; i++)
            {
                
                if (users[i].Email == email && users[i].Password == password) ;
                    
            }
            return true;
        }

        public void Register(User user)
        {
            if (usercount >= users.Length)
            {
                Console.WriteLine("Registration limit reached");
                return;
            }

            user.Id = usercount + 1;
            users[usercount] = user;
            usercount++;
            Console.WriteLine("\n Registration successful);");
        }

        public void DisplayMenu(object? publicManager = null)
        {
            while (true)
            {
                Console.WriteLine("\n...Welcome to hiring management system...");
                Console.WriteLine("1.Login");
                Console.WriteLine("2.Register");
                Console.WriteLine("3Exit");
                Console.WriteLine("choose an option : ");
                string? choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("Enter Email : ");
                        string email = Console.ReadLine() ?? "";

                        Console.WriteLine("Enter Password ");
                        string password = Console.ReadLine() ?? "";

                        if (Login(email, password))
                        {
                            var user = Array.Find(users, u => u != null && u.Email == email);

                            if (user.Role == Enums.Roles.ADMIN)
                            {
                                new AdminManager(users, usercount, jobManager).DisplayMenu(this);

                            }
                            else
                            {
                                new UserManager(jobManager).DisplayMenu(this);
                            }

                        }
                        else
                        {
                            Console.WriteLine("invalid credentials");
                        }
                        break;


                    case "2":
                        Console.WriteLine("\n...Register user...");

                        Console.WriteLine("First name");
                        string firstName = Console.ReadLine() ?? "";

                        Console.WriteLine("Last name");
                        string lastName = Console.ReadLine() ?? "";

                        Console.WriteLine("Email");
                        string useremail = Console.ReadLine() ?? "";

                        Console.WriteLine("Phone");
                        string phone = Console.ReadLine() ?? "";

                        Console.WriteLine("Password");
                        string userpassword = Console.ReadLine() ?? "";

                        Console.WriteLine("Select Role : 1 . Admin  2. JobSeeker");
                        Roles role = (Console.ReadLine() == "1") ? Roles.ADMIN : Roles.JOBSEEKER;


                        User newUser = new User()
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Email = useremail,
                            Password = userpassword,
                            Phone = phone,
                            Role = role
                        };

                        Register(newUser);
                        break;

                        case "3":
                        return;
                        

                }
            }
        }

    }
}
