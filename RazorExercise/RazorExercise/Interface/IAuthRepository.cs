using RazorExercise.Models;


namespace RazorExercise.Interface
{
    public interface IAuthRepository
    {
        public Task Register(User user);

        public Task<User> Login(User luser);
    }
}
