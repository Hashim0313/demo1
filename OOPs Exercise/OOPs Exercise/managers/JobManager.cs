using OOPs_Exercise.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs_Exercise.managers
{
    public class JobManager
    {
        public Job[] Jobs =
        {
            new Job(1, "Software Engineer", Enums.ExperienceLevel.Fresher, "TechCorp", "New York, NY", "$70,000 - $90,000", "Full-time"),
            new Job(2, "Data Analyst", Enums.ExperienceLevel.MidLevel, "DataSolutions", "San Francisco, CA", "$80,000 - $110,000", "Full-time"),
            new Job(3, "Project Manager", Enums.ExperienceLevel.Senior, "BusinessInc", "Chicago, IL", "$90,000 - $130,000", "Full-time"),
        };
        public int numJobs = 0;


        public void ListJobs()
        {
           for (int i = 0;i<Jobs.Length;i++)
            {
                if (Jobs[i] != null)
                {
                    Console.WriteLine($"ID: {Jobs[i].Id}, Title: {Jobs[i].Title}, Level: {Jobs[i].Level}, Company: {Jobs[i].Company}, Location: {Jobs[i].Location}, Salary Range: {Jobs[i].SalaryRange}, Job Type: {Jobs[i].JobType}");
                }
                
            }
        }



        public void PrintJobs(Job[] jobs)
        {
            foreach( Job job in jobs)
            {
                Console.WriteLine($"ID: {job.Id}, Title: {job.Title}, Level: {job.Level}, Company: {job.Company}, Location: {job.Location}, Salary Range: {job.SalaryRange}, Job Type: {job.JobType}");

            }

        }

        public Job GetJobById(int jobId)
        {
            Job returnedJob = new Job();
            for (int i = 0;i <Jobs.Length;i++)
            {
                if (Jobs[i].Id == jobId)
                {
                    returnedJob = Jobs[i]; 
                    break;
                }
            }
            return returnedJob;
        }

    }
}
