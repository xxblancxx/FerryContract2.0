using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox3_Library_Hundige
{
    [Serializable]
    class WeightCapacityException : ArgumentOutOfRangeException
    {
        public WeightCapacityException(string message) : base(message)
        {

        }
    }
}
