using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLib;
using Message.Classes;
using Message.Interfaces;

namespace Message.Factories
{
    public class ExtendedConsoleFactory
    {
        public static AbstractMessage Get()
        {
            char messageType = Helper.GetSelection(new char[] { '0', '1' }, "\"0\" for a short message; \"1\" for a long message");

            char senderType = Helper.GetSelection(new char[] { '0', '1', '2' }, "\"0\" for Email; \"1\" for SMS; \"2\" for Facsimile");
            IMessageSender sender = senderType == '0' ? new EmailSender() : senderType == '1' ? new SMSSender() : new FacsimileSender();

            char processorType = Helper.GetSelection(new char[] { '0', '1' }, "\"0\" for MessageProcessorA; \"1\" for MessageProcessorB");
            IMessageProcessor processor = processorType == '0' ? new MessageProcessorA() : new MessageProcessorB();

            Console.WriteLine("Pls enter the message that you want to send.");
            string Msg = Console.ReadLine() ?? string.Empty;

            return messageType == '0' ? ShortMessage.Create(sender, processor, Msg) : LongMessage.Create(sender, processor, Msg);
        }
    }
}

