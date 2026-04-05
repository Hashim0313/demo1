using Exercise1.Enums;
using System;

namespace Exercise1.Models
{
    public class JobSeeker
    {
        public int id;
        public string firstName;
        public string lastName;
        public string email;
        public string phone;
        public string location;
        public string aboutMe;
        public string qualification;
        public ExperienceLevels experience;
        public string password;

        public Job[] appliedJobs = new Job[100];
        public int numAppliedJobs = 0;

        public Job[] savedJobs = new Job[100];
        public int numSavedJobs = 0;

        public JobSeeker(int id, string firstName, string lastName, string email, string phone, string location, string aboutMe, string qualification, ExperienceLevels experience, string password)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.phone = phone;
            this.location = location;
            this.aboutMe = aboutMe;
            this.qualification = qualification;
            this.experience = experience;
            this.password = password;
        }

        public void addAppliedJobs(Job job)
        {
            if (numAppliedJobs >= appliedJobs.Length)
            {
                Console.WriteLine("Applied Jobs Limit Reached!!");
                return;
            }

            appliedJobs[numAppliedJobs++] = job;
            Console.WriteLine("Applied Job Added Successfully!!");
        }

        public void getAppliedJobs()
        {
            Console.WriteLine("List of Applied Jobs:");
            for (int i = 0; i < numAppliedJobs; i++)
            {
                Job job = appliedJobs[i];
                Console.WriteLine($"Job ID: {job.id}, Title: {job.title}, Company: {job.company}, Location: {job.location}, Salary: {job.salaryRange}, Type: {job.jobType}, Experience: {job.experience}");
            }
        }

        public void addSavedJob(Job job)
        {
            if (numSavedJobs >= savedJobs.Length)
            {
                Console.WriteLine("Saved Jobs Limit Reached!!");
                return;
            }

            savedJobs[numSavedJobs++] = job;
            Console.WriteLine("Saved Job Added Successfully!!");
        }

        public void getSavedJobs()
        {
            Console.WriteLine("List of Saved Jobs:");
            for (int i = 0; i < numSavedJobs; i++)
            {
                Job job = savedJobs[i];
                Console.WriteLine($"Job ID: {job.id}, Title: {job.title}, Company: {job.company}, Location: {job.location}, Salary: {job.salaryRange}, Type: {job.jobType}, Experience: {job.experience}");
            }
        }
    }
}