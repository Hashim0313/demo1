using RazorWorkshop.Dto;
using RazorWorkshop.Model;



namespace RazorWorkshop.Interface
{
    public interface IAuthServices
    {
        public  Task Register(UserRegisterDto registerDto);

        public Task<UserRegisterDto> Login(UserLoginDto loginDto);

    }
}
