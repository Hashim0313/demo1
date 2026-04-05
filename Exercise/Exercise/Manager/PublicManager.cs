using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Models;
using Exercise.Interface;
using Exercise.Interface;
using Exercise.Models;
using Exercise.Enums;
using Exercise.Manager;
using Exercise.Repository;

namespace Exercise.Manager
{
    public class PublicManager
    {
        

        UserRepository publicmanage = new UserRepository();

        public User loggeduser;

        public void DisplayMenu()
        {
            Console.WriteLine("Choose an option ");
            Console.WriteLine("1 : Register \n 2 : Login \n 3 : Logout");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    publicmanage.Register();
                    DisplayMenu();
                    break;

                case "2":
                   loggeduser =  publicmanage.Login();
                    if(loggeduser.Roles == Role.Admin)
                    {
                        AdminManager admin = new AdminManager();
                        admin.DisplayMenu();
                    }
                    DisplayMenu();
                    break;

                case "3":
                    Environment.Exit(0);
                    break;

            }
        }

    }
}
