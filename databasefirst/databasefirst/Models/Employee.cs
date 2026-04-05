using System;
using System.Collections.Generic;

namespace databasefirst.Models
{
    public partial class Employee
    {
        public int EmpId { get; set; }

        public string? Name { get; set; }

        public decimal? Empsalary { get; set; }

        public int? DepId { get; set; }

        public virtual Department? Dep { get; set; }
    }
}
