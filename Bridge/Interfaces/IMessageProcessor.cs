using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message.Interfaces
{
    public interface IMessageProcessor
    {
        string Process(string message);
    }
}
