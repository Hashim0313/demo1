using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace codefirst.models
{
    public class AppDbContext : DbContext
    {
        public DbSet<students> student { get; set; }

        public DbSet<collage> collages { get; set; }




        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            options.UseSqlServer("Data Source=ASUSTU7;Initial Catalog=codefirst;Integrated Security=True;Trust Server Certificate=True");

        }
    }



}
