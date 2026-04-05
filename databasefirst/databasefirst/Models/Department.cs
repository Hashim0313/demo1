using System;
using System.Collections.Generic;

namespace databasefirst.Models
{
    public partial class Department
    {
        public int DepId { get; set; }

        public string? Depname { get; set; }

        public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
    }
}
