using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Interfaces;

namespace Travel.Classes
{
    public class NullTravel : ITravel
    {
        public void GotoAirport() {  }
    }
}
