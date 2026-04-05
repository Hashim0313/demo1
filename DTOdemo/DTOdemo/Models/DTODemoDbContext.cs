using Microsoft.EntityFrameworkCore;

namespace DTOdemo.Models
{
    public class DTODemoDbContext : DbContext
    {


        public DTODemoDbContext (DbContextOptions <DTODemoDbContext> options) : base (options)
        {

        }

        public DbSet<Job> Jobs { get; set; }

    }
}
