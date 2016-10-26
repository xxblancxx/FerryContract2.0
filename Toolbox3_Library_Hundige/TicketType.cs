using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox3_Library_Hundige
{
    [Serializable]
    public class TicketType
    {
        public Price PriceOfTicket { get; set; }
        public TicketType(Price priceOfTicket)
        {
            PriceOfTicket = priceOfTicket;
        }
    }
}
