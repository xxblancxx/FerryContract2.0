using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox3_Library_Hundige
{
    [Serializable]
    class Ferry
    {
        public string Name { get; set; }
        public int PeopleCapacity { get; set; }
        public int VehicleCapacity { get; set; }
        public int WeightCapacityInKg { get; set; }
        public bool IsReserve { get; set; }
    }
}
