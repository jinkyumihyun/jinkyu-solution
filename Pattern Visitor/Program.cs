using Pattern_Visitor.Classes;
using Pattern_Visitor.Factories;

namespace Pattern_Visitor
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