using Enumerable.Classes;
using Iterator.Classes;
using System.Collections;
using System.Linq;

namespace Enumerable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design pattern: Iterator\n");

            Test();
        }
        static void Test()
        {
            Person[] people = Factory.Create();

            var enumerable = new People(people);
            Console.WriteLine("1) ForEach");
            enumerable.ForEach(p => Console.WriteLine(p));
            Console.WriteLine();

            Console.WriteLine("2) foreach");
            foreach (var person in enumerable)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();

            Console.WriteLine("3) foreach");
            foreach (var person in enumerable)
            {
                Console.WriteLine(person);
            }
            Console.WriteLine();

            Console.WriteLine("4) enumerator");
            IEnumerator enumerator = enumerable.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
            Console.WriteLine();

            Console.WriteLine("5) enumerator");
            enumerator.Reset();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }  
    }
    public static class Util
    {
        public static void ForEach(this People people, Action<Person> action)
        {
            foreach (var person in people)
            {
                action(person);
            }
        }
    }
}