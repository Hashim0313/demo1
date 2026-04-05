using Workshop.Interface;
using Workshop.Models;
using Workshop.Repository;

namespace Workshop.Manager
{
    public class AdminManager : IMenu
    {
        IJobProvider Jobs = new JobManager();
        private User loggedUser;
        private UserRepository ADMINS = new UserRepository();
        private Lists display = new Lists();


        public AdminManager(User loggedUser)
        {
            this.loggedUser = loggedUser;
        }
        public void DisplayMenu()
        {
            ShowAdminMenu();
        }

        public void ShowAdminMenu()
        {
            Console.WriteLine("1.List all admins\n2.My profile\n3.Post a job\n4.List all jobs\n5.Log out");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        var users = ADMINS.GetAll();
                        display.Print(users);
                        ShowAdminMenu();
                        break;
                    }

                case "2":
                    {
                        ViewProfile();
                        ShowAdminMenu();
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("Enter JobTitle");
                        string title = Console.ReadLine();
                        Console.WriteLine("Enter job description");
                        string description = Console.ReadLine();
                        Console.WriteLine("Enter job location");
                        string location = Console.ReadLine();
                        Console.WriteLine("Enter job type");
                        string type = Console.ReadLine();
                        Console.WriteLine("Enter salary range");
                        string salary = Console.ReadLine();
                        Console.WriteLine("Enter company");
                        string company = Console.ReadLine();
                        Job job = new Job(title, description, location, type, salary, company);
                        Jobs.PostJob(job);
                        Console.WriteLine("Job Posted successfully");
                        ShowAdminMenu();
                        break;
                    }
                case "4":
                    {
                        List<Job> jobs = Jobs.GetJobs();
                        display.Print(jobs);
                        ShowAdminMenu();
                        break;
                    }
                case "5":
                    {
                        Logout();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid choice");
                        ShowAdminMenu(); break;
                    }
            }
        }

        public void ViewProfile()
        {
            User loggeduser = ADMINS.GetLoggedUser();
            Console.WriteLine("-------------MyProfile--------------");
            Console.WriteLine($"First Name:{loggeduser.FirstName}");
            Console.WriteLine($"Last Name:{loggeduser.LastName}");
            Console.WriteLine($"Email:{loggeduser.Email}");
            Console.WriteLine($"Phone:{loggeduser.Phone}");
            Console.WriteLine("\n");
        }
        public void Logout()
        {
            loggedUser = new User();
            Console.WriteLine("Logged out successfully");
        }
    }
}
