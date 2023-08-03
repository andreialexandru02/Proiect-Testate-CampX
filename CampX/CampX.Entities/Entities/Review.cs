﻿using System;
using System.Collections.Generic;

namespace CampX.Entities;

public partial class Review
{
    public int Id { get; set; }

    public int Rating { get; set; }

    public string? Content { get; set; }

    public int? CampsiteId { get; set; }

    public virtual Campsite? Campsite { get; set; }
}