using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace codefistactivity1.models
{
    internal class studentappdbcontext : DbContext
    {
        public DbSet<students> student { get; set; }
        public DbSet<mark> marks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=ASUSTU7;Initial Catalog=codefirstactivity1;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
