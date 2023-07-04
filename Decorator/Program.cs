using Decorator.Classes;
using HelperLib;
using System.ComponentModel.DataAnnotations;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Decorator\n");
            Test();
        }
            static void Test()
        {
            var pizza = new CheesePizza();
            var anchovy = new AnchovyPizzaDecorator();
            var chicken = new ChickenPizzaDecorator();
            var pepperony = new PepperonyDecorator();
            var pineapple = new PineAppleDecorator();

            anchovy.Decorate(pizza);
            chicken.Decorate(pizza);
            pepperony.Decorate(pizza);
            var pineapplePizza = pineapple.Decorate(pizza);
            Console.WriteLine(pineapplePizza);
            Console.WriteLine();

            anchovy.Decorate(chicken.Decorate(pepperony.Decorate(pineapple.Decorate(pizza))));
            Console.WriteLine(pineapplePizza);
            Console.WriteLine();

            var cheesePizza = new CheesePizza();
            cheesePizza.Decorate(anchovy).Decorate(chicken).Decorate(pepperony).Decorate(pineapple);
            Console.WriteLine(cheesePizza);
            Console.WriteLine();

            var plain = new PlainPizza();
            plain.Decorate(anchovy).Decorate(chicken).Decorate(pepperony).Decorate(pineapple).Decorate(chicken).Decorate(chicken);
            Console.WriteLine(plain);
        }
    }
}