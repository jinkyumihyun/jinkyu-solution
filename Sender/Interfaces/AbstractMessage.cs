using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sender.Interfaces
{
    public abstract class AbstractMessage
    {
        protected string message;
        //public string Message { get { return message; } }
        public abstract string ProcessMessage();
    }
}
