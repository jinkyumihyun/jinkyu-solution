using Iterator.Classes;
using Iterator.Interface;
using System.Buffers;
using System.Collections;

namespace Iterator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design patterns: Iterator, Singleton, Null Object\n");
            Test3();
        }

        static void Test3()
        {
            Console.WriteLine("ArrayCollection<IItem>");
            var arrayColl = new ArrayCollection<IItem>(Factory.Create());
            arrayColl.ForEach(i => Console.WriteLine(i));
            Console.WriteLine();

            Console.WriteLine("ArrayCollection<int>");
            int[] intArray = { 1, 2, 3, 4, 5, 6 };
            var arrayColl2 = new ArrayCollection<int>(intArray);
            arrayColl2.ForEach(i => Console.WriteLine(i));
            Console.WriteLine();

            Console.WriteLine("Collection");
            var collection = new Collection(Factory.Create().ToList());
            collection.ForEach(i => Console.WriteLine(i));
        }
        static void Test2()
        {
            var arrayColl = new ArrayCollection<IItem>(Factory.Create());
            foreach (IItem I in arrayColl.GetItem())
            {
                if (I is not NullItem)
                {
                    Console.WriteLine(I);
                }             
            }
        }
        static void Test1()
        {
            int[] intArray = { 1, 2, 3, 4, 5,6};
            var arrayColl = new ArrayCollection<int>(intArray);
  
            foreach (int i in arrayColl.GetItem()) 
            {
                Console.WriteLine(i);
            }
        }
        static void Test()
        {
            var collection = new Collection(Factory.Create().ToList());

            IIterator iterator = collection.CreateIterator();

            for (var emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                Console.WriteLine(emp);
            }

            Console.Read();
        }
    }
    static class Util
    {
        internal static void ForEach(this Collection collection, Action<IItem> action)
        {
            IIterator iterator = collection.CreateIterator();

            for (var emp = iterator.First(); !iterator.IsCompleted; emp = iterator.Next())
            {
                if (emp is not NullItem)
                {
                    action(emp);
                }              
            }
        }
        internal static void ForEach<T>(this ArrayCollection<T> arrayCollection, Action<T> action) 
        {
            foreach (T i in arrayCollection.GetItem())
            {
                if (i is not NullItem)
                {
                    action(i);
                }
            }
        }
    }
}
