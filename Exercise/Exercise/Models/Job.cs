using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise.Enums;

namespace Exercise.Models
{
    public class Job
    {
        
        public string Title;
        public ExperienceLevel Level;
        public string Company;
        public string Location;
        public string SalaryRange;
        public string JobType;

        public Job() { }

        public Job( string title, ExperienceLevel level, string company,string location, string salaryrange, string jobtype)
        {
            
            Title = title;
            Level = level;
            Company = company;
            Location = location;
            SalaryRange = salaryrange;
            JobType = jobtype;
        }
    }
}
