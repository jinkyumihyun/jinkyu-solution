using ATM.Classes;
using ChainResponsibility.Classes;
using ChainResponsibility.Interfaces;
using System.Runtime.InteropServices;
using System.Timers;
using static ChainResponsibility.Interfaces.AbstractHandler.Unit;

namespace ChainResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Design Pattern: Chain of Responsibility\n");
            Test4();
        }
        static void Test4()
        {
            Func<int, int, int, bool> func = (a, b, c) => { return a + b > c; };



            var a = ATest(func, 1,2,5);
            Console.WriteLine($"{a(5)}");
           

            Func<int, int> ATest(Func<int, int, int, bool> f, int a, int b, int c)
            {
                Console.WriteLine($"{f(a, b, c)}");
                Func<int, int> func2 = (a) => { return 3 * a; };
                return func2;
            }

        }
            static void Test3()
        {
            AbstractHandler? ATM = null;
            InstallFactory.CreateAll(ref ATM);

            while (true)
            {
                Console.Clear();
                Console.Write($"Please type in the amount(,or \"q\" to quit): ");
                string? amountString = Console.ReadLine();
                long amount = 0;
                if (long.TryParse(amountString, out amount))
                {
                    Console.WriteLine($"for the amount of {amount}");
                    ATM?.DispatchNotes(amount);
                }
                else
                {
                    if (amountString == "q")
                    {
                        Console.WriteLine("Bye!");
                        break;                                          
                    }
                    Console.WriteLine($"wrong formatted number: {amountString}\n");
                }
                Console.Write($"To keep going press any key...");
                Console.ReadKey();
            }
        }
        static void Test2()
        {
            AbstractHandler? ATM = null;
            InstallFactory.CreateAll(ref ATM);

            long Amount = 8567;
            Console.WriteLine($"for the amount of {Amount}");
            ATM?.DispatchNotes(Amount);
        }
        static void Test()
        {
            AbstractHandler? ATM = null;
            InstallFactory.CreateAll(ref ATM);

            long Amount = 123864;
            Console.WriteLine($"for the amount of {Amount}");
            ATM?.DispatchNotes(Amount);
        }
    }
}

