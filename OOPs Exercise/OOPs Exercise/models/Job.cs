using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOPs_Exercise.Enums;



namespace OOPs_Exercise.models
{
    public class Job
    {
        public int Id;
        public string Title;
        public ExperienceLevel Level;
        public string Company;
        public string Location;
        public string SalaryRange;
        public string JobType;
        public Job() { }

        public Job(int id, string title, ExperienceLevel level, string company, string location, string salaryRange, string jobType)
        {
            Id = id;
            Title = title;
            Level = level;
            Company = company;
            Location = location;
            SalaryRange = salaryRange;
            JobType = jobType;
        }
    }
}

   
