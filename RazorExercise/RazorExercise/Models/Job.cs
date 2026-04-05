using System;
using System.Collections.Generic;

namespace RazorExercise.Models;

public partial class Job
{
    public int JobId { get; set; }

    public string? Company { get; set; }

    public string? JobTitle { get; set; }

    public string? Location { get; set; }

    public long? Salary { get; set; }

    public virtual ICollection<AppliedJob> AppliedJobs { get; set; } = new List<AppliedJob>();
}
