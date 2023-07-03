
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender.Interfaces
{
    public abstract class AbstractSender
    {
        protected AbstractMessage message;
        public abstract void SendMessage();
        public abstract void SendMessage(AbstractMessage message);
    }
}
