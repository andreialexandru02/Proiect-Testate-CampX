﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampX.BusinessLogic.Implementations.Trips.Models
{
    public class TripNoFKModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }

        public bool IsPublic { get; set; }

        public DateTime? Date { get; set; }

        public string Code { get; set; } = null!;
    }
}
