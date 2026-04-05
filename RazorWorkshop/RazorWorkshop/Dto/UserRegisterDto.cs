using RazorWorkshop.Enums;



namespace RazorWorkshop.Dto
{
    public class UserRegisterDto
    {
        public int ID { get; set; }
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Password { get; set; }

        public Roles role { get; set; }

    }
}
