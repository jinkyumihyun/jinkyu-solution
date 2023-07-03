using Cache.Classes;

namespace Cache
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Singleton\n");
            Test3();
        }

        static void Test3()
        {
            Action[] actions = new Action[10];
            Parallel.For(0, actions.Length, index => actions[index] = () => PrintDetails(index));
            Parallel.Invoke(actions);
            Console.ReadLine();

            static void PrintDetails(int id)
            {
                SingletonCache singleton = SingletonCache.GetInstance();

                var randomTime = new Random();
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine($" Adding Id (key: {id}; value: {1001}) to Cache: result: {singleton.Add(id, 1001)}"); ;
                    Thread.Sleep(randomTime.Next(30));
                    Console.WriteLine($" Adding Same Id (key: {id}; value: {2001}) to Cache using Update: result: {singleton.Update(id, 2001)}");
                    Thread.Sleep(randomTime.Next(30));
                    Console.WriteLine($" Fetching Id'value From Cache: {singleton.Get(id)}");
                    Thread.Sleep(randomTime.Next(30));
                    Console.WriteLine($" Remove Id: {singleton.Remove(id)}");
                    Thread.Sleep(randomTime.Next(30));
                }
            }
        }

        static void Test2()
        {
            Parallel.Invoke(() => PrintTeacherDetails(), () => PrintStudentdetails());
            Console.ReadLine();

            static void PrintTeacherDetails()
            {
                SingletonCache fromTeacher = SingletonCache.GetInstance();
                fromTeacher.PrintDetails("From Teacher");
            }

            static void PrintStudentdetails()
            {
                SingletonCache fromStudent = SingletonCache.GetInstance();
                fromStudent.PrintDetails("From Student");
            }
        }
        static void Test()
        {
            SingletonCache cache = SingletonCache.GetInstance();

            Console.WriteLine(" Adding Keys and Values into Cache");
            Console.WriteLine($" Adding \"Id\" to Cache: key: \"{"Id"}\"; value: {1001}; result: {cache.Add("Id", 1001)}");
            Console.WriteLine($" Adding \"Name\" to Cache: key: \"{"Name"}\"; value: \"{"Pranaya"}\"; result: {cache.Add("Name", "Pranaya")}");
            Console.WriteLine($" Adding Same \"Id\" Key to Cache using Add: key: \"{"Id"}\"; value: {2001}; result: {cache.Add("Id", 2001)}");
            Console.WriteLine($" Adding Same \"Id\" Key to Cache using Update:key: \"{"Id"}\"; value: {2001}; result:  {cache.Update("Id", 2001)}");
            Console.WriteLine();

            Console.WriteLine(" Fetching Values from Cache");
            Console.WriteLine($" Fetching \"Id\" From Cache: {cache.Get("Id")}");
            Console.WriteLine($" Fetching \"Name\" From Cache: \"{cache.Get("Name")}\"");
            Console.WriteLine();

            Console.WriteLine(" Removing Values from Cache");
            Console.WriteLine($" Fetching \"Name\" From Cache: \"{cache.Get("Name")}\"");
            Console.WriteLine($" Remove \"Id\": {cache.Remove("Id")}");
            Console.WriteLine($" Accessing \"Id\" From Cache: \"{cache.Get("Id")}\"");
            Console.WriteLine();

            SingletonCache second = SingletonCache.GetInstance();
            Console.WriteLine(" Fetching Values from Cache");
            Console.WriteLine($" Fetching \"Id\" From Cache: \"{cache.Get("Id")}\"");
            Console.WriteLine($" Fetching \"Name\" From Cache: \"{cache.Get("Name")}\"");
            Console.WriteLine();

            cache.Clear();
            Console.WriteLine(" Clearing All Keys and Values");
            Console.WriteLine($" Fetching \"Name\" From Cache: \"{cache.Get("Name")}\"");
        }
    }
}
