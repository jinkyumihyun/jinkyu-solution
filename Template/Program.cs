using Template.Classes;

namespace Template
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design patterns: Template\n");

            var special = new SpecialCoffee();
            special.PrepareCoffee(120.0);
            Console.WriteLine();

            var nescafe = new NescafeCoffee();
            nescafe.PrepareCoffee(200.0);
            Console.WriteLine();

            var bru = new BrewCoffee();
            bru.PrepareCoffee(300.0);
        }
    }
}