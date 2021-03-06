﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox3_Library_Hundige
{
    [Serializable]
    public class Departure
    {
        public Ferry SailingFerry { get; set; }
        public DateTime DateAndTime { get; set; }

        public Departure(Ferry sailingFerry, DateTime dateAndTime)
        {
            SailingFerry = sailingFerry;
            DateAndTime = dateAndTime;
        }
    }
}
