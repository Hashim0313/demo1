using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Interface;
using Exercise.Models;
using Exercise.Enums;
using Exercise.Manager;
using Exercise.Repository;


namespace Exercise.Manager
{
    public class AdminManager : IAdmin
    {

        public UserRepository userrepo = new UserRepository();

        public JobManager managejob = new JobManager();


        public void DisplayMenu()
        {
            Console.WriteLine("Choose an option");
            Console.WriteLine("1 : New Registrations \n 2 : List All Jobs \n 3 : Post job \n 4 : Logout ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    userrepo.NewRegistration();
                    DisplayMenu();
                    break;

                case "2":
                    managejob.GetJobs();
                    DisplayMenu();
                    break;

                case "3":
                    managejob.PostJob();
                    DisplayMenu();
                    break;

                case "4":
                    Logout();
                    break;

                    
            }
            
        }

        public void Logout()
        { 
            Console.WriteLine("Logged out successfully");
            return;
        }
    }
}
