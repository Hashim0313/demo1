using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Razortask1.Models;

public partial class Razortask1Context : DbContext
{
    public Razortask1Context()
    {
    }

    public Razortask1Context(DbContextOptions<Razortask1Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Appointment> Appointments { get; set; }

    public virtual DbSet<Doctor> Doctors { get; set; }


    public virtual DbSet<User> Users { get; set; }



}