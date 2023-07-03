using ParamsCommand.Classes;

namespace ParamsCommand
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test();
        }

        static void Test()
        {
            Console.WriteLine("Design pattern: Parameterized Command");
            Console.WriteLine("Extension: ");
            Console.WriteLine();

            Document document = new Document("Annual Report");
            var open = new OpenCommand(document);
            var edit = new EditCommand(document);
            var save = new SaveCommand(document);
            var close = new CloseCommand(document);
            MenuOptions menu = new MenuOptions(open, edit, save, close);
            menu.ClickOpen(new object[] {555 });
            menu.ClickEdit(new object[] { "cccccccccc" });
            menu.ClickSave(new object[] {true});
            menu.ClickClose(new object[] {});
            Console.WriteLine();
        }
    }
}