using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toolbox3_Library_Hundige
{
    [Serializable]
    class PersonCapacityException : ArgumentOutOfRangeException
    {
        public PersonCapacityException(string message) : base(message)
        {

        }
    }
}
