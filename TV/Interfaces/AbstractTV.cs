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
        protected abstract AbstractTV StaySameState();
        public virtual AbstractTV TurnOn()
        {
            return StaySameState();
        }
        public virtual AbstractTV TurnOff()
        {
            return StaySameState();
        }
        public abstract void ChangeChannels(TVChannel channel);
    }
}
