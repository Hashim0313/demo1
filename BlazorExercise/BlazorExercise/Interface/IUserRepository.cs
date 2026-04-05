using BlazorExercise.Models;

namespace BlazorExercise.Interface
{
    public interface IUserRepository
    {
        Task<User> GetByEmailAsync(string Email);
        Task AddAsync(User user);
    }
}
