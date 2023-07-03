using Military.Classes;

namespace Military
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
            var companyDispenser = new BulletFirstDispenser(100000, 100);
            var company = Unit.Create(companyDispenser, "First Company");
            var companyDispenser2 = new BulletFirstDispenser(100000, 100);
            var company2 = Unit.Create(companyDispenser2, "Second Company");
            var battalionDispenser = new BulletFirstDispenser(400000, 400);
            var battalion = Unit.Create(battalionDispenser, "Battalion");
            var regimentDispenser = new BulletFirstDispenser(2000000, 2000);
            var regiment = Unit.Create(regimentDispenser, "Regiment");
            var divisionDispenser = new BulletFirstDispenser(8000000, 8000);
            var division = Unit.Create(divisionDispenser, "Division");
            company.NextUnit = battalion;
            company2.NextUnit = battalion;
            battalion.NextUnit = regiment;
            regiment.NextUnit = division;

            int bullets = 800000;
            int shells = 800;
            company.DispenseOrdinance(ref bullets, ref shells);

            int bullets2 = 900000;
            int shells2 = 6000;
            company2.DispenseOrdinance(ref bullets2, ref shells2);

            var companyShellFirstDispenser = new ShellFirstDispenser(100000, 100);
            var companyShellFirstDispenser2 = new ShellFirstDispenser(100000, 100);
            var battalionShellFirstDispenser = new ShellFirstDispenser(400000, 400);
            var regimentShellFirstDispenser = new ShellFirstDispenser(2000000, 2000);
            var divisionShellFirstDispenser = new ShellFirstDispenser(8000000, 8000);
            company.Dispenser = companyShellFirstDispenser;
            company2.Dispenser = companyShellFirstDispenser2;
            battalion.Dispenser = battalionShellFirstDispenser;
            regiment.Dispenser = regimentShellFirstDispenser;
            division.Dispenser = divisionShellFirstDispenser;

            bullets = 800000;
            shells = 800;
            company.DispenseOrdinance(ref bullets, ref shells);

            bullets2 = 900000;
            shells2 = 6000;
            company2.DispenseOrdinance(ref bullets2, ref shells2);
        }
        
    }
}