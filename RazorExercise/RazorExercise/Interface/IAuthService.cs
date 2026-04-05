using RazorExercise.Dto;

namespace RazorExercise.Interface
{
    public interface IAuthService
    {
        public Task Register(RegisterDto RDto);


        public Task<RegisterDto> Login(LoginDto LDto);
    }
}
