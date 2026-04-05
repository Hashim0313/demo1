using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Interface;
using Exercise.Models;
using Exercise.Enums;

namespace Exercise.Manager
{
    public class JobManager : IJob
    {
       static List<Job> jobs = new List<Job>();

        public void PostJob()
        {
            Console.WriteLine("Enter job title : ");
            string Title = Console.ReadLine();

            Console.WriteLine("Company : ");
            string Company = Console.ReadLine();

            Console.WriteLine("Location : ");
            string Location = Console.ReadLine();

            Console.WriteLine("Job type : ");
            string JobType = Console.ReadLine();


            ExperienceLevel Level = ExperienceLevel.Senior;
            Console.WriteLine("Choose Experience Level :  \n 1 : Fresher \n 2:Midlevel  \n 3: Senior ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Level = ExperienceLevel.Fresher;
                    break;
                case 2:
                    Level = ExperienceLevel.MidLevel;
                    break;

                case 3:
                    Level = ExperienceLevel.Senior;
                    break;

            };

            Console.WriteLine("Salary range : ");
            string SalaryRange = Console.ReadLine();


            jobs.Add(new Job(Title, Level, Company, Location, JobType, SalaryRange));

        }



        
        public void GetJobs()
        { 
           foreach(var j in jobs)
            {
                Console.WriteLine($"\nTitle : {j.Title}");
                Console.WriteLine($"\nCompany : {j.Company}");
                Console.WriteLine($"\nLocation : {j.Location}");
                Console.WriteLine($"\nJob type : {j.JobType}");
                Console.WriteLine($"\nExeperience Level : {j.Level}");
                Console.WriteLine($"\nSalary range : {j.SalaryRange}");
            }
        }


}
    }

