using System;
using System.Collections.Generic;

namespace RazorExercise.Models;

public partial class AppliedJob
{
    public int? UserId { get; set; }

    public int? JobId { get; set; }

    public int Id { get; set; }

    public virtual Job? Job { get; set; }

    public virtual User? User { get; set; }
}
