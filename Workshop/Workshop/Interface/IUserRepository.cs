using Workshop.Models;

namespace Workshop.Interface
{
    public interface IUserRepository
    {
        List<User> GetAll();
    }
}
