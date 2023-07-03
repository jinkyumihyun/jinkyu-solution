

using BeverageNS.Classes;

namespace BeverageNS
{
    internal class Program
    {
        static void Main(string[] args) => Test();
        static void Test() 
        { 
            Console.WriteLine("Design pattern: Builder\n");

            var director = new BeverageDirector();
            var beverage = director.MakeBeverage(new CoffeeBuilder(), 200);
            beverage.ShowBeverage();
            Console.WriteLine();

            beverage = director.MakeBeverage(new GreenTeaBuilder(), 200);
            beverage.ShowBeverage();
            Console.WriteLine();

            beverage = director.MakeBeverage(new RedTeaBuilder(), 400);
            beverage.ShowBeverage();
        }
    }
}