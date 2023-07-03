using HelperLib;
using Message.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message.Classes { 
    public class LongMessage : AbstractMessage
    {
        private LongMessage(IMessageSender messageSender, IMessageProcessor messageProcessor, string message)
            : base( messageSender, messageProcessor, message) { }
        public static LongMessage Create(IMessageSender messageSender, IMessageProcessor messageProcessor, string message)
          => (messageSender, messageProcessor, Helper.IsNullWhite(message)) switch
          {
              (null, _, _) => throw new ArgumentNullException(nameof(messageSender)),
              (_, null, _) => throw new ArgumentNullException(nameof(messageProcessor)),
              (_, _, null) => throw new ArgumentNullException(nameof(message)),
              (_, _, _) => new LongMessage(messageSender, messageProcessor, message)
          };
        public override void SendMessage() => messageSender.SendMessage(messageProcessor.Process(message));
    }
}
