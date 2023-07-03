using Ordinance.Classes;

namespace Ordinance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write($"Design Pattern: Chain of Responsibility\n\n");
            Test();
        }
        static void Test()
        {
            var companyDispenser = OrdinaryDispenser.Create(100000, 100);
            var company = Unit.Create(companyDispenser, "First Company");
            var companyDispenser2 = OrdinaryDispenser.Create(100000, 100);
            var company2 = Unit.Create(companyDispenser2, "Second Company");
            var battalionDispenser = OrdinaryDispenser.Create(400000, 400);
            var battalion = Unit.Create(battalionDispenser, "Battalion");
            var regimentDispenser = OrdinaryDispenser.Create(2000000, 2000);
            var regiment = Unit.Create(regimentDispenser, "Regiment");
            var divisionDispenser = OrdinaryDispenser.Create(8000000, 8000);
            var division = Unit.Create(divisionDispenser, "Division");
            company.NextUnit = battalion;
            company2.NextUnit = battalion;
            battalion.NextUnit = regiment;
            regiment.NextUnit = division;

            int bullets = 1000000;
            int shells = 1800;
            company.DispenseOrdinance(ref bullets, ref shells);

            int bullets2 = 900000;
            int shells2 = 6000;
            company2.DispenseOrdinance(ref bullets2, ref shells2);

            bullets = 800000;
            shells = 800;
            company.DispenseOrdinance(ref bullets, ref shells);

            bullets2 = 900000;
            shells2 = 6000;
            company2.DispenseOrdinance(ref bullets2, ref shells2);
        }
        
    }
}