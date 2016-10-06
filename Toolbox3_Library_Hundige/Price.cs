using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox3_Library_Hundige
{
    [Serializable]
    class Price
    {
        public double Amount { get; set; }
        public Route ConnectedRoute { get; set; }
    }
}
