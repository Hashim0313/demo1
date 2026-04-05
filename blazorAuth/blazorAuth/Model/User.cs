using System.ComponentModel.DataAnnotations;

namespace blazorAuth.Model
{
    public class User
    {

        [Key]
        public int ID { get; set; }


        [Required , StringLength(100)]
        public string UserName { get; set; }


        [Required, StringLength(255)]
        public string PasswordHash { get; set; }


        [Required, StringLength(100)]
        public string Email { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

    }
}
