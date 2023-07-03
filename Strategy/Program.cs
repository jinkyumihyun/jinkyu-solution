using Strategy.Classes;
using Strategy.Interfaces;

namespace Strategy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Design pattern: Strategy\n");

            ICompression strategy = new ZipCompression();
            CompressionContext ctx = new CompressionContext(strategy);
            ctx.CreateArchive("DotNetDesignPattern");
            ctx.SetStrategy(new RarCompression());
            ctx.CreateArchive("DotNetDesignPattern");
            ctx.SetStrategy(new SpecialCompression());
            ctx.CreateArchive("DotNetDesignPattern");
        }
    }
}