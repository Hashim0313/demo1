using BlazorExercise.Models;
using BlazorExercise.Dto;

namespace BlazorExercise.Interface
{
    public interface IAuthService
    {
        Task<bool> Register(UserDto registerDto);

        Task<bool> Login(string email, string password);

    }
}
