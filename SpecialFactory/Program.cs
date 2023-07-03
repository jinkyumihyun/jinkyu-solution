using SpecialFactory.Classes;

namespace SpecialFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Factory\n");
            Test1();
        }
        static void Test1()
        {
            var item2 = ExtendedFactory.Get().Lower().TwoThree().Two();
            Console.WriteLine($"type: {item2};    name: {item2.Name}");
            var item9 = ExtendedFactory.Get().Extra().Nine();
            Console.WriteLine($"type: {item9};    name: {item9.Name}");
        }


            static void Test()
        {
            var testItem0 = Factory.Get().Lower().TwoThree().Two();
            Console.WriteLine($"type: {testItem0};    name: {testItem0.Name}");

            var testItem1 = Factory.Get().Upper().FourFive().Four();
            Console.WriteLine($"type: {testItem1};    name: {testItem1.Name}");
        }
    }
}