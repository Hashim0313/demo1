using Microsoft.EntityFrameworkCore;

namespace RazorWorkshop.Model
{
    public class JobDbContext : DbContext
    {

        public JobDbContext (DbContextOptions <JobDbContext> options) : base (options)
        {

        }

        public DbSet <Job> JobsInfo { get; set; }

        public DbSet <User> UsersInfo { get; set; }

    }
}
