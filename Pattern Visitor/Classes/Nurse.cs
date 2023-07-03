using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelperLib;
using Pattern_Visitor.Factories;
using Pattern_Visitor.Interfaces;

namespace Pattern_Visitor.Classes
{
    public class Nurse : IVisitor
    {
        public string Name { get; }

        Func<IElement, Func<string>> _selector;
        public string NurseOperation() => $"\"NurseOperation\"";
        private Nurse(string name, Func<IElement, Func<string>> selector)
            => (Name, _selector) = (name, selector);
        public static Nurse Create(string name, Func<IElement, Func<string>> selector)
         => (Helper.IsNullWhite(name), selector) switch
         {
             (null, _) => throw new ArgumentNullException(nameof(name)),
             (_, null) => throw new ArgumentNullException(nameof(selector)),
             (_, _) => new Nurse(name, selector)
         };
        public void Visit(IElement el)
        {
            Func<string> operation = _selector(el);
            Console.WriteLine($"Nurse: {Name}: {NurseOperation()} => Name: {el.Name}: {operation()}");
        }
    }
   
}
