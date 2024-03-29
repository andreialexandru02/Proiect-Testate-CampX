﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CampX.Entities;

public partial class Campsite
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public int Difficulty { get; set; }

    public decimal Latitude { get; set; }

    public decimal Longitude { get; set; }

    public int CamperId { get; set; }

    public virtual Camper Camper { get; set; } = null!;

    public decimal Rating { get; set; }

    public virtual ICollection<Night> Nights { get; set; } = new List<Night>();

    public virtual ICollection<Review> Reviews { get; set; } = new List<Review>();

    public virtual ICollection<Image> Images { get; set; } = new List<Image>();

    public virtual ICollection<Trip> Trips { get; set; } = new List<Trip>();
}
