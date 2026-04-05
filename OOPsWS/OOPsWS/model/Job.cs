using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsWS.model
{
    public class Job
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string location { get; set; }
        public string salary { get; set; }

        public Job(int id, string title, string description, string location, string salary)
        {
            this.id = id;
            this.title = title;
            this.description = description;
            this.location = location;
            this.salary = salary;
        }
    }
}
