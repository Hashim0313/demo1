using Exercise1.Models;
using Exercise1.Enums;
using System;

namespace Exercise1.Managers
{
    public class JobSeekerManager
    {
        public JobSeeker[] jobSeekers = new JobSeeker[100];
        public int seekerCount = 0;

        public JobSeeker loggedInJobSeeker = null;
        public JobManager jobManager = new JobManager();

        public void RegisterJobSeeker()
        {
            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Location: ");
            string location = Console.ReadLine();

            Console.Write("About Me: ");
            string aboutMe = Console.ReadLine();

            Console.Write("Qualification: ");
            string qualification = Console.ReadLine();

            Console.Write("Experience Level (Fresher/MidLevel/Senior): ");
            ExperienceLevels experience = (ExperienceLevels)Enum.Parse(typeof(ExperienceLevels), Console.ReadLine(), true);

            Console.Write("Password: ");
            string password = Console.ReadLine();

            JobSeeker newSeeker = new JobSeeker(seekerCount + 1, firstName, lastName, email, phone, location, aboutMe, qualification, experience, password);
            jobSeekers[seekerCount++] = newSeeker;

            Console.WriteLine("Registration successful!");
        }

        public void LoginJobSeeker()
        {
            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            for (int i = 0; i < seekerCount; i++)
            {
                if (jobSeekers[i].email == email && jobSeekers[i].password == password)
                {
                    loggedInJobSeeker = jobSeekers[i];
                    Console.WriteLine($"Welcome, {loggedInJobSeeker.firstName}!");
                    ShowJobSeekerMenu();
                    return;
                }
            }

            Console.WriteLine("Invalid credentials.");
        }

        public void ShowJobSeekerMenu()
        {
            while (loggedInJobSeeker != null)
            {
                Console.WriteLine("\n--- Job Seeker Menu ---");
                Console.WriteLine("1. View Profile");
                Console.WriteLine("2. List Available Jobs");
                Console.WriteLine("3. Apply for a Job");
                Console.WriteLine("4. Save a Job");
                Console.WriteLine("5. View Applied Jobs");
                Console.WriteLine("6. View Saved Jobs");
                Console.WriteLine("7. Logout");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1": ViewProfile(); break;
                    case "2": jobManager.ListJobs(); break;
                    case "3": ApplyJob(); break;
                    case "4": SaveJob(); break;
                    case "5": loggedInJobSeeker.getAppliedJobs(); break;
                    case "6": loggedInJobSeeker.getSavedJobs(); break;
                    case "7": Logout(); break;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
        }

        public void ApplyJob()
        {
            Console.Write("Enter Job ID to apply: ");
            int jobId = Convert.ToInt32(Console.ReadLine());

            Job job = jobManager.GetJobById(jobId);
            if (job != null)
            {
                loggedInJobSeeker.addAppliedJobs(job);
            }
        }

        public void SaveJob()
        {
            Console.Write("Enter Job ID to save: ");
            int jobId = Convert.ToInt32(Console.ReadLine());

            Job job = jobManager.GetJobById(jobId);
            if (job != null)
            {
                loggedInJobSeeker.addSavedJob(job);
            }
        }

        public void ViewProfile()
        {
            Console.WriteLine("\n--- Profile Details ---");
            Console.WriteLine($"Name: {loggedInJob}