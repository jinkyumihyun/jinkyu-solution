using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message.Interfaces
{
    public abstract class AbstractMessage
    {
        protected string message;
        protected IMessageSender messageSender;
        protected IMessageProcessor messageProcessor;
        protected AbstractMessage(IMessageSender messageSender, IMessageProcessor messageProcessor, string message)
            => (this.message, this.messageSender, this.messageProcessor) = (message, messageSender, messageProcessor);
        public abstract void SendMessage();
    }
}
