using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using OOPs_Exercise.Enums;

namespace OOPs_Exercise.models
{
    public class JobSeeker
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Email;
        public string PhoneNumber;
        public string Location;
        public string AboutMe;
        public string Qualifications;
        public ExperienceLevel Level;
        public string Password;

        public Job[] jobs = new Job[100];
        public int numappJobs = 0;

        public Job[] savedJobs = new Job[100];
        public int numSavedJobs = 0;

        public JobSeeker(int id, string firstName, string lastName, string email, string phoneNumber, string location, string aboutMe, string qualifications, ExperienceLevel level, string password)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
            PhoneNumber = phoneNumber;
            Location = location;
            AboutMe = aboutMe;
            Qualifications = qualifications;
            Level = level;
            Password = password;
        }



     

        public void addAppliedJob(Job job)
        {
           

            if (numappJobs == jobs.Length)
            {
                Console.WriteLine("Job list is full. Cannot add more jobs.");
                return;
            }

            jobs[numappJobs++] = job;
            Console.WriteLine($"Job applied successfully.");

        }

        public void GetAppliedJobs()
        {
            if (numappJobs == 0)
            {
                Console.WriteLine("No applied jobs found.");
                return;
            }
            Console.WriteLine("List of Applied Jobs:");
            for (int i = 0; i < numappJobs; i++)
            {
                Job job = jobs[i];
                Console.WriteLine($"ID: {job.Id}, Title: {job.Title}, Level: {job.Level}, Company: {job.Company}, Location: {job.Location}, Salary Range: {job.SalaryRange}, Job Type: {job.JobType}");
            }

        }

        public void AddSavedJob(Job job)
        {
            if (numSavedJobs == savedJobs.Length)
            {
                Console.WriteLine("Saved job list is full.");
                return;
            }
            savedJobs[numSavedJobs++] = job;
            Console.WriteLine($"Job saved successfully.");

        }

        public void getSavedJobs()
        {
            if (numSavedJobs == 0)
            {
                Console.WriteLine("No saved jobs found.");
                return;
            }
            Console.WriteLine("List of Saved Jobs:");
            for (int i = 0; i < numSavedJobs; i++)
            {
                Job job = savedJobs[i];
                Console.WriteLine($"ID: {job.Id}, Title: {job.Title}, Level: {job.Level}, Company: {job.Company}, Location: {job.Location}, Salary Range: {job.SalaryRange}, Job Type: {job.JobType}");
            }
        }

        
    }

}
