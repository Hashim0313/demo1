using Microsoft.EntityFrameworkCore;

namespace BlazorExercise2.Models
{
    public class AppDbContext : DbContext
    {
       public AppDbContext(DbContextOptions <AppDbContext> options) :base (options)
        {

        }

        public DbSet<Job1> Jobs1 { get; set; }

    }
}
