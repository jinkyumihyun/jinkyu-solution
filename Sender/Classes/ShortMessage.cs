using Sender.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender.Classes
{
    public class ShortMessage : AbstractMessage
    {
        public ShortMessage(string Message)
        {
            this.message = Message;
        }

        public override string ProcessMessage()
        {
            if (message.Length <= 10)
            {
                return "Processed short message: " + message;
            }
            else
            {
                return string.Empty;
            }
            
        }
    }
}

