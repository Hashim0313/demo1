using Microsoft.EntityFrameworkCore;

namespace BlazorWorkshop.Models
{
    public class JobProviderDbContext : DbContext
    {

        public JobProviderDbContext(DbContextOptions <JobProviderDbContext> options) : base (options)
        {

        }

        public DbSet <JobProvider> JobProviders { get; set; }

        public DbSet <Job> Jobs { get; set; }

    }
}
