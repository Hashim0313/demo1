using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace databasefirst.Models
{
    public partial class ServerfirstContext : DbContext
    {
        public ServerfirstContext()
        {
        }

        public ServerfirstContext(DbContextOptions<ServerfirstContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
            => optionsBuilder.UseSqlServer("Data Source=ASUSTU7;Initial Catalog=serverfirst;Integrated Security=True;Trust Server Certificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasKey(e => e.DepId).HasName("PK__departme__00D7A2935B1E8060");

                entity.ToTable("department");

                entity.Property(e => e.DepId)
                    .ValueGeneratedNever()
                    .HasColumnName("depID");
                entity.Property(e => e.Depname)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("depname");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpId).HasName("PK__employee__AFB3EC6DDA84EDF2");

                entity.ToTable("employee");

                entity.Property(e => e.EmpId)
                    .ValueGeneratedNever()
                    .HasColumnName("empID");
                entity.Property(e => e.DepId).HasColumnName("depID");
                entity.Property(e => e.Empsalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("empsalary");
                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("name");

                entity.HasOne(d => d.Dep).WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DepId)
                    .HasConstraintName("FK__employee__depID__398D8EEE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
