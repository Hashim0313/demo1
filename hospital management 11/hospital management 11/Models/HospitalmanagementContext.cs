using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace hospital_management_11.Models;

public partial class HospitalmanagementContext : DbContext
{
    public HospitalmanagementContext()
    {
    }

    public HospitalmanagementContext(DbContextOptions<HospitalmanagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=ASUSTU7;Initial Catalog=hospitalmanagement;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Appointment>(entity =>
        {
            entity.HasKey(e => e.AppointmentId).HasName("PK__Appointm__D067651EFB412E93");

            entity.Property(e => e.AppointmentId).HasColumnName("appointmentID");
            entity.Property(e => e.Appointmentdate)
                .HasColumnType("datetime")
                .HasColumnName("appointmentdate");
            entity.Property(e => e.DoctorId).HasColumnName("doctorID");
            entity.Property(e => e.Patientname)
                .HasMaxLength(100)
                .HasColumnName("patientname");

            entity.HasOne(d => d.Doctor).WithMany(p => p.Appointments)
                .HasForeignKey(d => d.DoctorId)
                .HasConstraintName("FK__Appointme__docto__4BAC3F29");
        });

        modelBuilder.Entity<Doctor>(entity =>
        {
            entity.HasKey(e => e.DoctorId).HasName("PK__Doctors__72248596DD73F69E");

            entity.Property(e => e.DoctorId).HasColumnName("doctorID");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Specialization)
                .HasMaxLength(100)
                .HasColumnName("specialization");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
