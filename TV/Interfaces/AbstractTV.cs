using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TV.Interfaces.ITVState;

namespace TV.Interfaces
{
    public abstract class AbstractTV : ITVState
    {
        public TVChannel Channel { get; set; }
        public virtual AbstractTV? TurnOn()
        {
            return null;
        }
        public virtual AbstractTV? TurnOff()
        {
            return null;
        }
        public abstract void ChangeChannels(TVChannel channel);
    }
}
