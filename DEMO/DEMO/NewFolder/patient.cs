using Exercise1.Models;
using System;

namespace Exercise1.Managers
{
    public class JobManager
    {
        public Job[] Jobs = new Job[100];
        public int jobCount = 0;

        public void AddJob(Job job)
        {
            if (jobCount >= Jobs.Length)
            {
                Console.WriteLine("Job list is full!");
                return;
            }

            Jobs[jobCount++] = job;
            Console.WriteLine("Job added successfully.");
        }

        public void ListJobs()
        {
            Console.WriteLine("Available Jobs:");
            PrintJobs(Jobs, jobCount);
        }

        public void PrintJobs(Job[] jobs, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Job job = jobs[i];
                Console.WriteLine($"ID: {job.id}, Title: {job.title}, Company: {job.company}, Location: {job.location}, Salary: {job.salaryRange}, Type: {job.jobType}, Experience: {job.experience}");
            }
        }

        public Job GetJobById(int jobId)
        {
            for (int i = 0; i < jobCount; i++)
            {
                if (Jobs[i].id == jobId)
                {
                    return Jobs[i];
                }
            }

            Console.WriteLine($"Job with ID {jobId} not found.");
            return null;
        }
    }
}