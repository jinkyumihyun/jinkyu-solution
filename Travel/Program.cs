using Travel.Classes;
using Travel.Factories;

namespace Travel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design pattern: Strategy\n");
            Test4();
        }
        static void Test4()
        {
            var travel = ExtendedTypeFactory.Get();
            TravelContext context = new TravelContext(travel);
            context.GotoAirport();
            Console.WriteLine("constructor dependency injection\n");

            travel = ExtendedTypeFactory.Get();
            context.TravelStrategy = travel;
            context.GotoAirport();
            Console.WriteLine("property dependency injection\n");

            travel = ExtendedTypeFactory.Get();
            context.GotoAirport(travel);
            Console.WriteLine("parameter dependency injection\n");
        }
        static void Test3()
        {
            var travel = ExtendedFactory.Get();
            TravelContext context = new TravelContext(travel);
            context.GotoAirport();
            Console.WriteLine("constructor dependency injection\n");
        }
            static void Test2()
        {
            var travel = Factory.Get();
            TravelContext context = new TravelContext(travel);
            context.GotoAirport();
            Console.WriteLine("constructor dependency injection\n");

            travel = Factory.Get();
            context.GotoAirport(travel);
            Console.WriteLine("parameter dependency injection\n");

        }
        static void Test()
        {
            while (true)
            {            
                var travel = Factory.Get();
                if (travel is NullTravel)
                {
                    Console.WriteLine("Bye!");
                    return;
                }
                TravelContext context = new TravelContext(travel);
                context.GotoAirport();
                Console.WriteLine();
            }
        }
    }
}