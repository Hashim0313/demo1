using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RazorExercise.Models;

public partial class RazorExerciseContext : DbContext
{
    public RazorExerciseContext()
    {
    }

    public RazorExerciseContext(DbContextOptions<RazorExerciseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AppliedJob> AppliedJobs { get; set; }

    public virtual DbSet<Job> Jobs { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ASUSTU7;Initial Catalog=RazorExercise;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AppliedJob>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__AppliedJ__3214EC27FA4BCA6C");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.JobId).HasColumnName("JobID");
            entity.Property(e => e.UserId).HasColumnName("UserID");

            entity.HasOne(d => d.Job).WithMany(p => p.AppliedJobs)
                .HasForeignKey(d => d.JobId)
                .HasConstraintName("FK__AppliedJo__JobID__3B75D760");

            entity.HasOne(d => d.User).WithMany(p => p.AppliedJobs)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__AppliedJo__UserI__3A81B327");
        });

        modelBuilder.Entity<Job>(entity =>
        {
            entity.HasKey(e => e.JobId).HasName("PK__Jobs__056690E289764EF8");

            entity.Property(e => e.JobId).HasColumnName("JobID");
            entity.Property(e => e.Company)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.JobTitle)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Location)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACDF0E9A23");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Name)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
