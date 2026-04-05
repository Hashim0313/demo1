using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Razortask1.Enums;

namespace Razortask1.Models
{
    public class User
    {
        [Key]
        
        public int UserID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public Roles Role { get; set; }
    }
}
