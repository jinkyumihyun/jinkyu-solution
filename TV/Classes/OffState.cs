using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TV.Interfaces;
using static TV.Interfaces.ITVState;

namespace TV.Classes
{
    public class OffState : AbstractTV
    {
        public OffState(TVChannel channel) 
            => Channel = channel; 

        public override AbstractTV TurnOn()
        {
            Console.WriteLine($"turning on the TV...");
            return StateFactory.Get(TVState.TVOn, Channel);
        }
        public override void ChangeChannels(TVChannel channel) 
            => Console.WriteLine($"No change: Current state: Off; Channel {(int)Channel}");
    }
}