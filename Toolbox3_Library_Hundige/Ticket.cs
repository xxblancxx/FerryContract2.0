using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox3_Library_Hundige
{
    [Serializable]
    public class Ticket
    {
        public Reservation ReservationForTicket { get; set; }
        public TicketType Type { get; set; }
        public Vehicle Transportation { get; set; }
        public Customer RefCustomer { get; set; }

        public Ticket(Reservation reservationForTicket, TicketType type, Vehicle transportation, Customer referencedCustomer)
        {
            ReservationForTicket = reservationForTicket;
            Type = type;
            Transportation = transportation;
            RefCustomer = referencedCustomer;

        }
    }
}
