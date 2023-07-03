using Observers.Classes;
using Observers.Interfaces;
using System.Diagnostics;
using System.Runtime.Intrinsics.Arm;

namespace Observers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design patterns: Observer");
            Console.WriteLine("Extension: a ring of three Subjects instead of one Subject");
            Test();
        }
        static void Test()
        {
            Console.WriteLine("First Market with its shoppers\n");
            ISubject FM = new Market("First Market");
            IObserver John = new Shopper("John");
            FM.RegisterObserver(John);
            IObserver James = new Shopper("James");
            FM.RegisterObserver(James);
            IObserver Mary = new Shopper("Mary");
            FM.RegisterObserver(Mary);
            IObserver Joy = new Shopper("Joy");
            FM.RegisterObserver(Joy);

            Console.WriteLine("Second Market with its shoppers\n");
            ISubject SM = new Market("Second Market");
            IObserver Jessi = new Shopper("Jessi");
            SM.RegisterObserver(Jessi);
            IObserver Austin = new Shopper("Austin");
            SM.RegisterObserver(Austin);
            IObserver Jack = new Shopper("Jack");
            SM.RegisterObserver(Jack);
            IObserver Caitlin = new Shopper("Caitlin");
            SM.RegisterObserver(Caitlin);

            Console.WriteLine("Third Market with its shoppers\n");
            ISubject TM = new Market("Third Market");
            IObserver Marx = new Shopper("Marx");
            TM.RegisterObserver(Marx);
            IObserver Josep = new Shopper("Josep");
            TM.RegisterObserver(Josep);
            IObserver Beth = new Shopper("Beth");
            TM.RegisterObserver(Beth);
            IObserver Jan = new Shopper("Jan");          
            TM.RegisterObserver(Jan);

            Console.WriteLine("Markets are connected\n");
            FM.RegisterSubject(SM);
            SM.RegisterSubject(TM);
            TM.RegisterSubject(FM);

            Console.WriteLine("Markets send anouncements through the ring of markets");
            FM.SetPrice("carrot", 5);
            Console.WriteLine();

            SM.SetPrice("shoes", 50);
            Console.WriteLine();

            TM.SetPrice("bananas", 2);
            Console.WriteLine();

            Console.WriteLine("First and Second Markets are disconnected\n");
            SM.RemoveSubject(FM);
            //Console.WriteLine();

            FM.SetPrice("beef", 20);
            Console.WriteLine();

            SM.SetPrice("beef", 22);
            Console.WriteLine();

            TM.RemoveSubject(FM);
            //Console.WriteLine();

            FM.SetPrice("beef", 21);
            Console.WriteLine();

            TM.SetPrice("beef", 20);
            Console.WriteLine();
        }
    }
}