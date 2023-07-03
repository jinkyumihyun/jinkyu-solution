using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using HelperLib;
using Pattern_Visitor.Factories;
using Pattern_Visitor.Interfaces;

namespace Pattern_Visitor.Classes
{
    public class Salesman : IVisitor
    {
        public string Name { get; }

        Func<IElement, Func<string>> _selector;
        public string SalesmanOperation() => $"\"SalesmanOperation\"";
        private Salesman(string name, Func<IElement, Func<string>> selector)
            => (Name, _selector) = (name, selector);
        public static Salesman Create(string name, Func<IElement, Func<string>> selector)
       => (Helper.IsNullWhite(name), selector) switch
       {
           (null, _) => throw new ArgumentNullException(nameof(name)),
           (_, null) => throw new ArgumentNullException(nameof(selector)),
           (_, _) => new Salesman(name, selector)
       };
        public void Visit(IElement el)
        {
            Func<string> operation = _selector(el);
            Console.WriteLine($"Salesman: {Name}: {SalesmanOperation()} => Name: {el.Name}: {operation()}");
        }

    }
}
