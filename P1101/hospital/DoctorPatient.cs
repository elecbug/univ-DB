﻿using System;
using System.Collections.Generic;

namespace P1101.hospital;

public partial class DoctorPatient
{
    public int Id { get; set; }

    public int DoctorId { get; set; }

    public int PatientId { get; set; }

    public virtual Doctor Doctor { get; set; } = null!;

    public virtual Patient Patient { get; set; } = null!;
}
