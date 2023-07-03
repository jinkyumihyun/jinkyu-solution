using Sender.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender.Classes
{
    public class LongMessage : AbstractMessage
    {
        public LongMessage(string message) 
        {
            this.message = message;
        }
        public override string ProcessMessage()
        {
            return "Processed long message: " + message;
        }
    }
}
