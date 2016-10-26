using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox3_Library_Hundige
{
    [Serializable]
    public class Ferry
    {
        public string Name { get; set; }
        public int PeopleCapacity { get; set; }
        public int VehicleCapacity { get; set; }
        public int WeightCapacityInKg { get; set; }
        public bool IsReserve { get; set; }

        public Ferry(string name, int peopleCapacity, int vehicleCapacity, int weightCapacityInKg, bool isReserve)
        {
            Name = name;
            PeopleCapacity = peopleCapacity;
            VehicleCapacity = vehicleCapacity;
            WeightCapacityInKg = weightCapacityInKg;
            IsReserve = IsReserve;
        }
    }
}
