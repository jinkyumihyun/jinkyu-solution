using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TV.Interfaces
{
    public interface ITVState
    {
        enum TVState
        {
            TVOff,
            TVOn,          
        }
        enum TVChannel
        {
            ChannelOne = 1,
            ChannelTwo = 2,
            ChannelThree = 3,
            ChannelFour = 4,
            ChannelFive = 5,
            ChannelSix = 6,
            ChannelSeven = 7,
            ChannelEight = 8,
            ChannelNine = 9,
        }
    }
}
