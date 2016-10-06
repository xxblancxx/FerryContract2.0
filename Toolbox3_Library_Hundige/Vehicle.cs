﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox3_Library_Hundige
{
    [Serializable]
    class Vehicle
    {
        public enum CarOrTruck { None,Car, Truck }
        public bool IsTruck { get; set; }

        public Vehicle(CarOrTruck carOrTruck)
        {
            if (carOrTruck == CarOrTruck.Truck)
            {
                IsTruck = true;
            }
            else
            {
                IsTruck = false; // Redundant, but reads more easily.
            }
        }
    }
}
