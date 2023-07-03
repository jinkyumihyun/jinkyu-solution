using Composit.Classes;
using Composit.Interfaces;
using System.ComponentModel;

namespace Composit
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Composit\n");

            IComp Pranaya = Leaf.Create("Pranaya", 22000);
            IComp Rohit = Leaf.Create("Rohit", 33000);
            IComp Anurag = Leaf.Create("Anurag", 42000);
            IComp Priyanka = Leaf.Create("Priyanka", 52000);
            IComp Sambit = Leaf.Create("Sambit", 28000);

            IComposite ITDepartment = new Composite("ITDepartment");
            IComposite HRDepartment = new Composite("HRDepartment");
            IComposite Company = new Composite("Company");

            ITDepartment.AddComponent(Pranaya);
            ITDepartment.AddComponent(Rohit);
            ITDepartment.AddComponent(Anurag);
            HRDepartment.AddComponent(Priyanka);
            HRDepartment.AddComponent(Sambit);
            Company.AddComponent(ITDepartment);
            Company.AddComponent(HRDepartment);

            Console.WriteLine($"Total Salary of the Company: {Company.GetSalary()}");
            Console.WriteLine($"Total Salary of IT Department: {ITDepartment.GetSalary()}");
            Console.WriteLine($"Total Salary of HR Department: {HRDepartment.GetSalary()}");

            Pranaya.GetSalary();
            Anurag.GetSalary();
            Console.Read();
        }
    }
}