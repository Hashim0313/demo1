using OOPsWS.model;
using OOPsWS.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsWS.Manager
{
    public class JobManager : IJob
    {
        private int numJobs = 0;
        private Job[] jobs = new Job[100];
        
        public void AddJob()
        {
            if (numJobs == jobs.Length)
            {
                               Console.WriteLine("Job list is full. Cannot add more jobs.");
                return;
            }

            Console.WriteLine("Enter Job ID:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Job Title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Job Description:");
            string description = Console.ReadLine();

            Console.WriteLine("Enter Job Location:");
            string location = Console.ReadLine();

            Console.WriteLine("Enter Job Salary:");
            string salary = Console.ReadLine();

            Job newJob = new Job(id, title, description, location, salary);

            jobs[numJobs] = newJob;
            numJobs++;

            Console.WriteLine("Job added successfully.");

        }

        public void ListJob()
        {
            Console.WriteLine("Jobs : ");
            for (int i = 0; i < numJobs; i++)
            {
                Console.WriteLine("\n");
                Console.WriteLine($"Title : {jobs[i].title}");
                Console.WriteLine($"Description : {jobs[i].description}");
                Console.WriteLine($"Salary : {jobs[i].salary}");
                Console.WriteLine($"Location : {jobs[i].location}");
            }
        }
    }
}
