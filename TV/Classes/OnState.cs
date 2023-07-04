using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TV.Interfaces;
using static TV.Interfaces.ITVState;

namespace TV.Classes
{
    public class OnState : AbstractTV
    {
        public OnState(TVChannel channel) => Channel = channel; 
        public override AbstractTV TurnOff()
        {
            Console.WriteLine($"turning off the TV...");
            return StateFactory.Get(TVState.TVOff, Channel); 
        }
        public override void ChangeChannels(TVChannel channel)
        {
            if (Channel != channel)
            {
                Channel = channel;
                Console.WriteLine($"Channel changed to Channel {(int)Channel}");
                return;
            }
            Console.WriteLine($"Channel stays the same as Channel {(int)Channel}");         
        }
        protected override AbstractTV StaySameState()
           => StateFactory.Get(TVState.TVOn, Channel);
    }
}
