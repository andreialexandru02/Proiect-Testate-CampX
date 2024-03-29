﻿using System;
using System.Collections.Generic;

namespace CampX.Entities;

public partial class Badge
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Milestone { get; set; }

    public int ImageId { get; set; }

    public virtual ICollection<CamperBadge> CamperBadges { get; set; } = new List<CamperBadge>();

    public virtual Image Image { get; set; } = null!;
}
