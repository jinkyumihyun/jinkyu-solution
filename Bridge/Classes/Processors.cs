using Message.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message.Classes
{
    public class MessageProcessorA : IMessageProcessor
    {
        public string Process(string message) => "MessageProcessorA: Processed message:  " + message;
    }
    public class MessageProcessorB : IMessageProcessor
    {
        public string Process(string message) => "MessageProcessorB: Processed message:  " + message;
    }
}
