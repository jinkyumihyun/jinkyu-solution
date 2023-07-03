using Fluent.Classes;

namespace Fluent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Design pattern: Fluent\n");
            Test3();
        }
        static void Test3()
        {
            var a = AAA.Create("aaaaaa", "bbbbbb", new BBB());
            a.Show();
        }
            static void Test2()
        {
            Employee e = new Employee();
            e.NameOfTheEmployee("Anurag Mohanty")
                .Born("10/10/1992")
                .WorkingOn("IT")
                .StaysAt("Mumbai-India")
                .ShowDetails();
        }
            static void Test()
        {
            //Create an Instance of Wrapper class i.e. FluentEmployee
            FluentEmployee obj = new FluentEmployee(new Employee());
            //Call Methods one by one using dot Operator whose Return Type is FluentEmployee
            obj.NameOfTheEmployee("Anurag Mohanty")
                    .Born("10/10/1992")
                    .WorkingOn("IT")
                    .StaysAt("Mumbai-India");
            //To See the Details call the ShowDetails Method
            obj.ShowDetails();
            Console.Read();
        }
    }

    class BBB
    {
        public override string ToString()
        {
            return " BBBBBBBBBBBBBBBBB";
        }
    }
    class AAA
    {
        string _str;
        string _altStr;
        BBB _bbb;
        private AAA(string str, string altStr, BBB bbb) { _str = str; _altStr = altStr; _bbb = bbb; }

        public void Show()
        {
            Console.WriteLine(_str + ", " + _altStr + _bbb);
        }
        public static AAA Create(string str, string altStr, BBB bbb)
            => (IsNullWhiteSpace(str), IsNullWhiteSpace(altStr), bbb) switch
            {
                (null, _, _) => throw new ArgumentException(nameof(str)),
                (_, null, _) => throw new ArgumentException(nameof(altStr)),
                (_, _, null) => throw new ArgumentNullException(nameof(bbb)),
                (_, _, _) => new AAA(str, altStr, bbb)
            };
        static string? IsNullWhiteSpace(string str) => string.IsNullOrWhiteSpace(str) ? null : str;
    }
}