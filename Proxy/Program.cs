using Proxy.Classes;
using Proxy.Interfaces;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Proxy\n");

            IImage Image1 = new ProxyImage("Tiger Image");
            Console.WriteLine("Image1 calling DisplayImage first time :");
            Image1.DisplayImage(); // loading necessary
            Console.WriteLine("Image1 calling DisplayImage second time :");
            Image1.DisplayImage(); // loading unnecessary
            Console.WriteLine("Image1 calling DisplayImage third time :");
            Image1.DisplayImage(); // loading unnecessary
            Console.WriteLine();

            Image1.Filename = "Lion Image";
            Console.WriteLine("Image2 calling DisplayImage first time :");
            Image1.DisplayImage(); // loading necessary
            Console.WriteLine("Image2 calling DisplayImage second time :");
            Image1.DisplayImage(); // loading unnecessary
            Console.WriteLine();

            Image1.Filename = "Elephant Image";
            Console.WriteLine("Image1 calling DisplayImage first time :");
            Image1.DisplayImage(); // loading necessary
            Console.WriteLine("Image1 calling DisplayImage second time :");
            Image1.DisplayImage(); // loading unnecessary
            Console.WriteLine("Image1 calling DisplayImage third time :");
            Image1.DisplayImage(); // loading unnecessary
            Console.WriteLine();

            //Service A
            IServer s = new ProxyServer("bbbbb");
            s.Operate();
            Console.WriteLine();
            s.Operate();
            Console.WriteLine();

            //Service C
            s.ServiceName = "cccccccccc";
            s.Operate();
            Console.WriteLine();
            s.Operate();
            Console.WriteLine();
            s.Operate();
            Console.WriteLine();
            s.Operate();
            Console.WriteLine();

            //Service A
            s.Operate("aaaaaaaaaaaaaaaa");
            Console.WriteLine();

            //no Such service
            s.Operate("xxxxxxxxxxx");

            Console.ReadKey();
        }
    }

}