using Microsoft.EntityFrameworkCore;




namespace session.Models
{
    public class UserDbContext : DbContext
    {
        public UserDbContext (DbContextOptions <UserDbContext> options) : base (options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
