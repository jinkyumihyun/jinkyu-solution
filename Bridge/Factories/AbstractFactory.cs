using Message.Classes;
using Message.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Message.Factories
{
    public class AbstractFactory
    {
        public static AbstractMessage GetEmailLongA(string message)
        {
            return LongMessage.Create(new EmailSender(), new MessageProcessorA(), message);
        }
        public static AbstractMessage GetSMSLongA(string message)
        {
            return LongMessage.Create(new SMSSender(), new MessageProcessorA(), message);
        }
        public static AbstractMessage GetEmailShortA(string message)
        {
            return ShortMessage.Create(new EmailSender(), new MessageProcessorA(), message);
        }
        public static AbstractMessage GetSMSShortA(string message)
        {
            return ShortMessage.Create(new SMSSender(), new MessageProcessorA(), message);
        }
        public static AbstractMessage GetEmailLongB(string message)
        {
            return LongMessage.Create(new EmailSender(), new MessageProcessorB(), message);
        }
        public static AbstractMessage GetSMSLongB(string message)
        {
            return LongMessage.Create(new SMSSender(), new MessageProcessorB(), message);
        }
        public static AbstractMessage GetEmailShortB(string message)
        {
            return ShortMessage.Create(new EmailSender(), new MessageProcessorB(), message);
        }
        public static AbstractMessage GetSMSShortB(string message)
        {
            return ShortMessage.Create(new SMSSender(), new MessageProcessorB(), message);
        }
    }
}
