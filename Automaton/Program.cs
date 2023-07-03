using Automaton.Classes;

namespace Automaton
{
    internal class Program
    {
        static void Main(string[] args) => Test();
        static void Test()
        {
            Console.WriteLine("Design pattern: Interpreter");
            var automaton = new Context();
            automaton.Evaluate();
        }
    }
}