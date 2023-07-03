using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using TV.Interfaces;
using static TV.Interfaces.ITVState;
using static TV.Interfaces.ITVState.TVChannel;

namespace TV.Classes
{
    public class StateFactory
    {
        private static AbstractTV[] _state = new AbstractTV[] 
        { 
            new OffState(ChannelOne), 
            new OnState(ChannelOne) 
        };
        public static AbstractTV Get(TVState state, TVChannel channel)
        {
            AbstractTV tmp;
            switch (state)
            {
                case TVState.TVOff:
                    tmp = _state[(int)TVState.TVOff];
                    tmp.Channel = channel;
                    return tmp;
                case TVState.TVOn:
                    tmp = _state[(int)TVState.TVOn];
                    tmp.Channel = channel;
                    return tmp;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}
