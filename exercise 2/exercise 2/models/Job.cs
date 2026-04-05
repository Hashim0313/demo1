using exercise_2.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise_2.models
{
    public class Job
    {
        public int Id;
        public string Title =string.Empty;
        public ExperienceLevel Level;
        public string Company = string.Empty;
        public string Location = string.Empty;
        public string SalaryRange = string.Empty;
        public string? JobType; 
    }
}
