using Microsoft.EntityFrameworkCore;


namespace Employee_Management.Models
{
    public class EmployeeDbContext : DbContext
    {

    public EmployeeDbContext(DbContextOptions<EmployeeDbContext>options):base (options)
        {

        }

        public DbSet<Employee1> Employees { get; set; }

    }
}
