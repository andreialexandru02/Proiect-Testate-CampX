﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampX.BusinessLogic.Implementations.Trips.Models
{
    public class TripCamperIdModel
    {
        public int TripId { get; set; }

        public int CamperId { get; set; }

       // public int? NoteId { get; set; }

        public bool IsOrganizer { get; set; }
    }
}
