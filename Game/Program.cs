using Game.Classes;
using HelperLib;
using System.Data;
using System.Linq.Expressions;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design pattern: Command\n");
            Test1();
        }
        static void Test1() {

            var game = new VideoGame("Basketball");
            var control = RemoteControl.Create(game)!;

            while (true)
            {
                Console.Clear();
                Console.WriteLine($"Game: {game.Name}: Status: {control.Status()}\n" 
                    + "Option: s: Start; c: Score; e: End; u: Undo; r: Redo; n: new game; x: Exit ");
                Console.Write("Please choose one option: ");
                switch (Helper.GetSelectingChar(Console.ReadLine()))
                {
                    case 's':
                        control.Start();
                        break;
                    case 'c':
                        control.ShowScore();
                        break;
                    case 'e':
                        control.End();
                        break;
                    case 'u':
                        control.Undo();
                        break;
                    case 'r':
                        control.Redo();
                        break;
                    case 'n':
                        Console.Write("Please type in a new game name: ");
                        string name = Helper.GetSelectingStr(Console.ReadLine());
                        game = new VideoGame( name == string.Empty ? "Default(Basketball)" : name);
                        control = RemoteControl.Create(game)!;
                        break;
                    case 'x':
                        Console.WriteLine($"Bye!");
                        return;
                    default:
                        Console.WriteLine($"null or empty string, wrong value in option char");
                        break;
                }
                Console.Write($"To keep going press any key...");
                Console.ReadKey();
            }
        }
        static void Test()
        {
            //check game
            var game = new VideoGame("Basketball");
            var control = RemoteControl.Create(game)!;
           
            control.Start();
            control.Redo();
            control.ShowScore(); 
            control.Redo();
            control.Redo();
            control.End();
            control.Redo();

            control.SetGame(new VideoGame("Ping Pong"));
            control.Start();
            control.ShowScore();
            control.ShowScore();
            control.End();

            control.Undo();
            control.Undo();
            control.Redo();
            control.Start();
            control.ShowScore();
            control.End();

            var control2 = RemoteControl.Create(new VideoGame("Ping Pong"))!;
            var game2 = new VideoGame("Baseball");
            
            control2.Start();
            control2.ShowScore();
            control2.ShowScore();
            control2.ShowScore();
            control2.End();
            control2.Undo();
            control2.Redo();
            control2.Redo();
            control2.Redo();
            control2.Undo();
            control2.Undo();
            control2.Undo();
            control2.Undo();
        }
    }
}