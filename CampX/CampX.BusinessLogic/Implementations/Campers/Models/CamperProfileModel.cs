﻿using CampX.BusinessLogic.Implementations.Trips.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampX.BusinessLogic.Implementations.Campers.Models
{
    public class CamperProfileModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public bool isBanned { get; set; }

        public List<CamperBadgeModel> CamperBadges { get; set; }

        public List<TripForCamperProfileModel> Trips { get; set; }
    }
}
