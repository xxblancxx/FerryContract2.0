using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox3_Library_Hundige
{
    [Serializable]
    class Reservation
    {
        public Departure RefDeparture { get; set; }
        public int ReservationNumber { get; set; }
        public bool HasArrived { get; set; }

        public Reservation(Departure referencedDeparture, int reservationNumber, bool hasArrived)
        {
            RefDeparture = referencedDeparture;
            ReservationNumber = reservationNumber;
            HasArrived = hasArrived;
        }
    }
}
