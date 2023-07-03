using Sender.Classes;
using Sender.Interfaces;

namespace Sender
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Bridge\n");
            Test2();
        }

        static void Test2()
        {
            AbstractSender sender = CascadeFactory.GetEmailSender().GetSender();
            sender.SendMessage(new ShortMessage("cccccccccccccccccccccccccc"));
            Console.WriteLine();
            sender.SendMessage(new ShortMessage("ccc"));
            sender.SendMessage(new LongMessage("cccccccccccccccccccccccccc"));
            Console.WriteLine();


            AbstractSender secondSender = CascadeFactory.GetSMSsender().GetSender(); ;
            secondSender.SendMessage(new ShortMessage("cccccccccccccccccccccccccc"));
            secondSender.SendMessage(new LongMessage("cccccccccccccccccccccccccc"));
        }
        static void Test()
        {
            AbstractSender sender = CascadeFactory.GetEmailSender()
                .GetLongMessage("This is an example long message.");
            sender.SendMessage();
            Console.WriteLine();

            AbstractSender secondSender = CascadeFactory.GetSMSsender()
                .GetShortMessage("This is an example short message.");
            secondSender.SendMessage();
        }
    }
}