using Plain.Classes;

namespace Plain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Singleton\n");
            Test2();
        }

        static void Test2()
        {
            Action[] actions = new Action[10]; 
            Parallel.For(0, actions.Length, index => actions[index] = () => PrintDetails(index));
            Parallel.Invoke(actions);
            Console.ReadLine();

            static void PrintDetails(int id)
            {
                Singleton singleton = Singleton.GetInstance();

                var randomTime = new Random();
                for (int i = 0; i < 10; i++)
                {
                    singleton.GetTestValue(id);
                    Thread.Sleep(randomTime.Next(100));
                }
            }
            Action[] GetActions(int numActions)
            {
                Action[] actions = new Action[numActions];
                for (int i = 0;i < numActions;i++)
                {
                    actions[i] = () => PrintDetails(i);
                }
                return actions;
            }
        }
        static void Test()
        {
            var firstSingleton = Singleton.GetInstance();
            var secondSingleton = Singleton.GetInstance();
            var thirdSingleton = Singleton.GetInstance();

            firstSingleton.GetTestValue(1);
            secondSingleton.GetTestValue(2);
            thirdSingleton.GetTestValue(3);
            firstSingleton.GetTestValue(1);
            secondSingleton.GetTestValue(2);
            thirdSingleton.GetTestValue(3);
            firstSingleton.GetTestValue(1);
            firstSingleton.GetTestValue(1);        }
    }
}