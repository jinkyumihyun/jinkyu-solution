using Event_Observer.Classes;

namespace Event_Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design patterns: Observer\n");
            Test();
        }
        static void Test()
        {
            Console.WriteLine("players created...\n");
            var market = new Publisher();
            var John = new Shopper("John");
            var Beth = new Shopper("Beth");
            var Liz = new Shopper("Liz");
            var Bob = new Shopper("Bob");

            Console.WriteLine("shoppers registered for public anouncement...\n");
            market.PublishEvent += John.ShowEvent;          
            market.PublishEvent += Beth.ShowEvent;          
            market.PublishEvent += Liz.ShowEvent;
            market.PublishEvent += Bob.ShowEvent;

            Console.WriteLine("market sets prices...");
            market.SetPrice("beef", 21);
            market.SetPrice("beef", 20);
            market.SetPrice("pork", 15);
            Console.WriteLine();

            Console.WriteLine("shoppers registered for per-request anouncement...\n");
            market.AskEvent += Liz.ShowEvent;
            market.AskEvent += John.ShowEvent;

            Console.WriteLine("one shopper registered as an asker for per-request anouncement...\n");
            John.Publisher = market;

            Console.WriteLine("he asks...");
            John.Ask("beef");
            John.Ask("soup");
            John.Ask("pork");
        }
    }
}