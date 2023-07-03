using Message.Classes;
using Message.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Message.Factories
{
    internal class Factory
    {
        public static AbstractMessage? Create(char processorChar, char senderChar, char lengthChar, string msg)
        {
            var processor = CreateProcessor(processorChar);
            if (processor is null) return null;

            var sender = CreateSender(senderChar);
            if (sender is null) return null;

            return CreateMessage(lengthChar, sender, processor, msg);
        }
        public static AbstractMessage? Create(char[] selections, string msg)
        {
            if (selections == null || selections.Length < 3) return null;

            var processor = CreateProcessor(selections[0]);
            if (processor is null) return null;

            var sender = CreateSender(selections[1]);
            if (sender is null) return null;

            return CreateMessage(selections[2], sender, processor, msg);
        }
        private static AbstractMessage? CreateMessage(char length, IMessageSender sender, IMessageProcessor processor, string msg)
            => length switch
            {
                's' => ShortMessage.Create(sender, processor, CheckMessage(msg)),
                'l' => LongMessage.Create(sender, processor, CheckMessage(msg)),
                _ => null
            };
        private static IMessageSender? CreateSender(char sender)
            => sender switch
            {
                's' => new SMSSender(),
                'f' => new FacsimileSender(),
                'e' => new EmailSender(),
                _ => null
            };
        private static IMessageProcessor? CreateProcessor(char processor)
             => processor switch
             {
                 'a' => new MessageProcessorA(),
                 'b' => new MessageProcessorB(),
                 _ => null
             };
        private static string CheckMessage(string msg)
        {
            return string.IsNullOrWhiteSpace(msg) ? string.Empty : msg;
        }
    }
}
