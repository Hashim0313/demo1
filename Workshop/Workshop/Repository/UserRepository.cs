using Workshop.Enums;
using Workshop.Interface;
using Workshop.Models;

namespace Workshop.Repository
{
    public sealed class UserRepository : IUserRepository
    {
        private List<User> users = new List<User>
        {
            new User (1,"admin","", "admin1@gmail.com",123, Roles.ADMIN,"123"),
            new User (2, "admin", "", "admin2@gmail.com", 123,Roles.ADMIN,"123"),
            new User (3, "admin", "", "admin3@gmail.com",123,Roles.ADMIN,"123")
        };

        private static User loggedUser;
        private int nextId = 2;

        public List<User> GetAll()
        {
            return users.Where(e => e.Role == Roles.ADMIN).ToList();
        }

        public User login(string email, string password)
        {
            loggedUser = users.FirstOrDefault(e => e.Email == email && e.Password == password);
            return loggedUser;
        }

        public User GetLoggedUser()
        {
            return loggedUser;
        }
    }
}
