using Message.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Message.Classes
{
    public class SMSSender : IMessageSender
    {
        public void SendMessage(string Message) => Console.WriteLine($"{Message}\nThis Message has been sent using SMS");
    }

    public class FacsimileSender : IMessageSender
    {
        public void SendMessage(string Message) => Console.WriteLine($"{Message}\nThis Message has been sent using Facsimile.");
    }

    public class EmailSender : IMessageSender
    {
        public void SendMessage(string Message) => Console.WriteLine($"{Message}\nThis Message has been sent using Email.");
    }
}
