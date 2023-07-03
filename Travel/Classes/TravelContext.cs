using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Interfaces;

namespace Travel.Classes
{
    public class TravelContext
    { 
        public ITravel TravelStrategy {get; set;}
        public TravelContext(ITravel strategy) 
            => TravelStrategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
        public void GotoAirport() 
            => (TravelStrategy).GotoAirport();
        public void GotoAirport(ITravel travelStrategy)
            => travelStrategy.GotoAirport();
    }
}
