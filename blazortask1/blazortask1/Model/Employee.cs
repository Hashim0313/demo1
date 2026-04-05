using System.ComponentModel.DataAnnotations;

namespace blazortask1.Model
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        public int Age { get; set; }


        public decimal Salary { get; set; }
    }
}
