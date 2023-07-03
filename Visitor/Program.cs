using Visitor.Classes;
using Visitor.Factories;

namespace Visitor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design patterns: Visitor\n");

            School school = School.Create(ElemFactory.Get(), VisitorFactory.Get());           
            school.PerformOperations();        
        }
    }
}