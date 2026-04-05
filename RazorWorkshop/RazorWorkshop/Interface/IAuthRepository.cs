using RazorWorkshop.Dto;
using RazorWorkshop.Model;

namespace RazorWorkshop.Interface
{
    public interface IAuthRepository
    {
        public Task Register(User user);

        public Task<User> Login(User dto);

    }
}
