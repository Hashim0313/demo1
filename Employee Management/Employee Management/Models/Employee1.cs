using System.ComponentModel.DataAnnotations;
namespace Employee_Management.Models
{
    public class Employee1
    {
        public int ID { get; set; }

        [Required]

        public string Name { get; set; }

        [Required]


        public string Position { get; set; }

        [Required]
        [Range (1000,100000)]

        public decimal Salary { get; set; }

        [Required]

        public string Department { get; set; }




    }
}
