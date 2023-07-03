using Adaptor.Classes;
using Adaptor.Interfaces;
using Employees.Classes;

namespace Adaptor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Adaptor\n");
            //The EmployeeAdapter Makes it possible to work with Two Incompatible Interfaces
            Console.WriteLine("HR system passes employee string array to Adapter\n");
            ITarget target = new EmployeeAdapter(new ThirdPartyBillingSystem());
            target.ProcessCompanySalary(ArrayFactory.Create());
        }
    }
}