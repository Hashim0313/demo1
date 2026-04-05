using Microsoft.EntityFrameworkCore;

namespace blazorAuth.Model
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions <AppDbContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

    }
}
