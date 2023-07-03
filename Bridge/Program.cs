using Message.Factories;
using Message.Interfaces;

namespace Message
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Bridge\n");
            Test3();
        }
        static void Test3()
        {
            AbstractMessage? message = Factory.Create(new char[] { 'a', 'f', 'l'}, "This is a sample long message.");
            message?.SendMessage();
            Console.WriteLine();
        }
        static void Test2()
        {
            AbstractMessage message3 = ExtendedConsoleFactory.Get();
            message3.SendMessage();
            Console.WriteLine();
        }
        static void Test1()
        {
            AbstractMessage message = AbstractFactory.GetEmailLongA("This is a test long message.");
            message.SendMessage();
            Console.WriteLine();

            message = AbstractFactory.GetSMSShortB("a short message longer than 20 chars.");
            message.SendMessage();
        }

        static void Test()
        {
            AbstractMessage message = ConsoleFactory.Get();
            Console.WriteLine();
            message.SendMessage();
        }
    }
}