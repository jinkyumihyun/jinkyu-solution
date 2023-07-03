using HelperLib;
using Message.Classes;
using Message.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Message.Classes
{
    public class ShortMessage : AbstractMessage
    {
        private ShortMessage(IMessageSender messageSender, IMessageProcessor messageProcessor, string message)
             : base(messageSender, messageProcessor, message) { }
        public static ShortMessage Create(IMessageSender messageSender, IMessageProcessor messageProcessor, string message)
            => (messageSender, messageProcessor, Helper.IsNullWhite(message)) switch
            {
                (null, _, _) => throw new ArgumentNullException(nameof(messageSender)),
                (_, null, _) => throw new ArgumentNullException(nameof(messageProcessor)),
                (_, _, null) => throw new ArgumentNullException(nameof(message)),
                (_, _, _) => new ShortMessage(messageSender, messageProcessor, message)
            };
        public override void SendMessage()
        {
            if (message.Length > 20)
            {
                Console.WriteLine("Warning:  message is too long. not deliberable.");
            }
            else
            {
                messageSender.SendMessage(messageProcessor.Process(message));
            }           
        }
    }
   
}

