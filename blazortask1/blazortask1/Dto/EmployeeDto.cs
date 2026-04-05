using System.ComponentModel.DataAnnotations;

namespace blazortask1.Dto
{
    public class EmployeeDto
    {

        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Position { get; set; }

        public decimal Salary { get; set; }

    }
}
