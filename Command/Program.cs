using Command.Classes;
using Command.Interfaces;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design pattern: Command");
            Console.WriteLine("Extension: Smart constructor\n");

            Document document = new Document("Annual Report");
            var factory = new Factory();
            MenuOptions menu = MenuOptions.Create(factory.GetCommandSet(document));
            menu.ClickAll();
            Console.WriteLine();

            document = new Document("Special Report");
            menu = MenuOptions.Create(factory.GetCommandSet(document));
            menu.ClickAll();
            Console.WriteLine();

            menu = MenuOptions.Create(factory.GetCommandSet("Finanacial Report")!);
            menu.ClickAll();
        }
    }
}
