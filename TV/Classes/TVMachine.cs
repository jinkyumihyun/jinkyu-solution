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
    public class TVMachine
    {
        // A reference to the current state of the Context.
        private AbstractTV _tVMachineState = StateFactory.Get(TVState.TVOff, TVChannel.ChannelOne);
        public void TurnOn() => _tVMachineState = _tVMachineState.TurnOn()!;
        public void TurnOff() => _tVMachineState = _tVMachineState.TurnOff()!;
        public void ChangeChannels(TVChannel channel) => _tVMachineState.ChangeChannels(channel);        
    }
}
