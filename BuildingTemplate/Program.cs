using BuildingTemplate.Classes;

namespace BuildingTemplate
{
    internal class Program
    {
        static void Main(string[] args) => Test();
        static void Test() 
        {
            Console.WriteLine("Design patterns: Template\n");

            var familyhome = new FamilyHome();
            familyhome.Build();
            Console.WriteLine();

            var warehouse = new Warehouse();
            warehouse.Build();
            Console.WriteLine();

            var hut = new Hut();
            hut.Build();
        }
    }
}