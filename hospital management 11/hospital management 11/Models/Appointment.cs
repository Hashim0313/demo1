using System;
using System.Collections.Generic;

namespace hospital_management_11.Models;

public partial class Appointment
{
    public int AppointmentId { get; set; }

    public string? Patientname { get; set; }

    public DateTime? Appointmentdate { get; set; }

    public int? DoctorId { get; set; }

    public virtual Doctor? Doctor { get; set; }
}
