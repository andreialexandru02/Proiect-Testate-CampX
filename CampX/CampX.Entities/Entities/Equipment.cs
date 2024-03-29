﻿using System;
using System.Collections.Generic;

namespace CampX.Entities;

public partial class Equipment
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<EquipmentCamperTrip> EquipmentCamperTrips { get; set; } = new List<EquipmentCamperTrip>();
}
