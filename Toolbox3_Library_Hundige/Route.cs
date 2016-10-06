using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox3_Library_Hundige
{
    [Serializable]
    class Route
    {
        public Departure RefDeparture { get; set; }
        public string Destination { get; set; }
        public TimeSpan Duration { get; set; }
    }
}
