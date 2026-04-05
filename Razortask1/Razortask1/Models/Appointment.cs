using System;
using System.Collections.Generic;

namespace Razortask1.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public string? PatientName { get; set; }

    public DateTime? AppointmentDate { get; set; }

    public int? DoctorId { get; set; }



    public int UserID { get; set; }

    public User User { get; set; }

    public virtual Doctor? Doctor { get; set; }



}
