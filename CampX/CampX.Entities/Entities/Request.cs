﻿using System;
using System.Collections.Generic;

namespace CampX.Entities;

public partial class Request
{
    public int TripId { get; set; }

    public int CamperId { get; set; }

    public DateTime? Date { get; set; }

    public string? Description { get; set; }

    public virtual Camper Camper { get; set; } = null!;

    public virtual Trip Trip { get; set; } = null!;
}
