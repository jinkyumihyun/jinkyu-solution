using HelperLib;
using Interpreter.Classes;
using Interpreter.Interfaces;
using System.ComponentModel;

namespace Interpreter
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Design pattern: Interpreter");
            SelectTest();
        } 

        static void Test2()
        {
            var context = new Classes2.Context();
            context.Evaluate();
        }
        static void Test1()
        {
            var context = new Context(DateTime.Now);
            context.Evaluate();
        }
        static void SelectTest()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Please select the test : 0) exit or 1) Test 1 or 2) Test 2.");
                switch (Helper.GetSelectingChar(Console.ReadLine()))
                {
                    case '0':
                        Console.WriteLine($"Bye!");
                        return;
                    case '1':
                        Console.WriteLine($"Test 1");
                        Test1();
                        break;
                    case '2':
                        Console.WriteLine($"Test 2: concise implementation");
                        Test2();
                        break;
                    default:
                        Console.WriteLine($"Wrong input");
                        break;
                }

                Console.WriteLine("Please type a key to go on.");
                Console.ReadKey();
            }
        }
    }
   
}
