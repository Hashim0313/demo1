using Microsoft.EntityFrameworkCore;


namespace BlazorAssessment.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions  <AppDbContext> options) : base(options)
        {
           
        }

      public DbSet<Customer> Customers;

    }
}
