using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HelperLib;
using Pattern_Visitor.Interfaces;

namespace Pattern_Visitor.Classes
{
    public class Dentist : IVisitor
    {      
        private Dentist(string name, Func<IElement, Func<string>> selector) => (Name, _selector) = (name, selector);
        public static Dentist Create(string name, Func<IElement, Func<string>> selector)
            => (Helper.IsNullWhite(name), selector) switch
            {
                (null, _) => throw new ArgumentNullException(nameof(name)),
                (_, null) => throw new ArgumentNullException(nameof(selector)),
                (_, _) => new Dentist(name, selector)
            };
        public string Name { get; }

        Func<IElement, Func<string>> _selector;
        public string DentistOperation() => $"\"DentistOperation\"";
        public void Visit(IElement el)
        {
            Func<string> operation = _selector(el);
            Console.WriteLine($"Dentist {Name}: {DentistOperation()} => Name: {el.Name}: {operation()}");
        }
    }
}
