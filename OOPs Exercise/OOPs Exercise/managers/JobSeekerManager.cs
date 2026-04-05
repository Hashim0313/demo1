using OOPs_Exercise.Enums;
using OOPs_Exercise.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOPs_Exercise.managers
{
    public class JobSeekerManager
    {
        public JobSeeker[] jobSeekers = new JobSeeker[100];
        public int SeekerCount = 0;

        public JobSeeker loggedInJobSeeker = null;
        public JobManager jobManager = new JobManager();


        public void RegisterJobSeeker()
        {
            Console.WriteLine("First name : ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last name : ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Email : ");
            string email = Console.ReadLine();

            Console.WriteLine("Phone : ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Location : ");
            string location = Console.ReadLine();

            Console.WriteLine("About Me : ");
            string aboutme = Console.ReadLine();

            Console.WriteLine("Qualification");
            string qualification = Console.ReadLine();

            Console.WriteLine("Experience level");
            ExperienceLevel level = (ExperienceLevel)Enum.Parse(typeof(ExperienceLevel), Console.ReadLine(),true);

            Console.WriteLine("Password : ");
            string password = Console.ReadLine();

            JobSeeker newSeeker = new JobSeeker(SeekerCount + 1, firstName, lastName, email, phoneNumber, location, aboutme, qualification, level, password);
            jobSeekers[SeekerCount++] = newSeeker;

            Console.WriteLine("Registration successful");

        }

        public void LoginJobSeeker()
        {
            Console.WriteLine("Email : ");
            string email = Console.ReadLine();

            Console.WriteLine("Password : ");
            string password = Console.ReadLine();
            for (int i = 0; i < jobSeekers.Length; i++)
            {
                if (jobSeekers[i].Email == email && jobSeekers[i].Password == password)
                {
                    loggedInJobSeeker = jobSeekers[i];
                    Console.WriteLine($"Welcome,{loggedInJobSeeker.FirstName}");
                    ShowJobSeekerMenu();
                    return;
                }
            }
            Console.WriteLine("Invalid email or password.");

        }

        public void ShowJobSeekerMenu()
        {
            while (loggedInJobSeeker != null)
            {
                Console.WriteLine("\n     Job Seeker Menu ");
                Console.WriteLine("1. view Profile");
                Console.WriteLine("2. View All Jobs");
                Console.WriteLine("3. Apply for a Job");
                Console.WriteLine("3. Save a Job");
                Console.WriteLine("4. View Applied Jobs");
                Console.WriteLine("5. view Saved jobs");
                Console.WriteLine("7. Logout");
                Console.WriteLine("Choose an option : ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": ViewProfile();
                        break;
                    case "2":
                        jobManager.ListJobs();
                        break;
                    case "3": ApplyJob();
                        break;
                    case "4": SaveJob();
                        break;
                    case "5": loggedInJobSeeker.GetAppliedJobs();
                        break;
                    case"6": loggedInJobSeeker.getSavedJobs();
                        break;
                    case "7": Console.WriteLine("Logging out...");
                        Environment.Exit(0);
                        break;
                        default: Console.WriteLine("invalid option");
                        break;

                }

            }
        }
        public void ApplyJob()
        {
            Console.WriteLine("Enter job id to apply : ");
            int jobId = Convert.ToInt32(Console.ReadLine());

            Job job = jobManager.GetJobById(jobId);
            if (job != null)
            {
                loggedInJobSeeker.addAppliedJob(job);
            }
        }
        public void SaveJob()
        {
            Console.Write("Enter Job ID to save: ");
            int jobId = Convert.ToInt32(Console.ReadLine());

            Job job = jobManager.GetJobById(jobId);
            if (job != null)
            {
                loggedInJobSeeker.AddSavedJob(job);
            }
        }
        public void ViewProfile()
        {
            Console.WriteLine($"\nProfile of {loggedInJobSeeker.FirstName} {loggedInJobSeeker.LastName}");
            Console.WriteLine($"ID: {loggedInJobSeeker.Id}");
            Console.WriteLine($"Email: {loggedInJobSeeker.Email}");
            Console.WriteLine($"Phone: {loggedInJobSeeker.PhoneNumber}");
            Console.WriteLine($"Location: {loggedInJobSeeker.Location}");
            Console.WriteLine($"About Me: {loggedInJobSeeker.AboutMe}");
            Console.WriteLine($"Qualification: {loggedInJobSeeker.Qualifications}");
            Console.WriteLine($"Experience Level: {loggedInJobSeeker.Level}");
        }


    }
}
