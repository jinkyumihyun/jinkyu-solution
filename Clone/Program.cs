using Clone.Classes;

namespace Clone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Prototype\n");

            var t = new Test();
            Console.WriteLine(t.ToString());

            var s = (Test)t.Clone();
            Console.WriteLine(s.ToString());

            var u = (Test)s.Clone();
            u.i = 55;
            u.j = new[] { 7,8,9,0, 5, 3, 8, 2, 11}; 
            Console.WriteLine(u.ToString());

            var v = (Test)u.Clone();
            Console.WriteLine(v);

            var w = CloneHelper<Test>.CreateDeepCopyBinary(v);
            Console.WriteLine(w.ToString());

            var x = CloneHelper<Test>.CreateDeepCopyXML(t);
            Console.WriteLine(x.ToString());
        }
    }
}