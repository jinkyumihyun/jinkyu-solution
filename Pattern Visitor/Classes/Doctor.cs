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
    public class Doctor : IVisitor
    {
        public string Name { get; }

        Func<IElement, Func<string>> _selector;
        public string DoctorOperation() => $"\"DoctorOperation\"";
        private Doctor(string name, Func<IElement, Func<string>> selector)
            => (Name, _selector) = (name, selector ?? throw new ArgumentNullException(nameof(selector)));
        public static Doctor Create(string name, Func<IElement, Func<string>> selector)
          => (Helper.IsNullWhite(name), selector) switch
          {
              (null, _) => throw new ArgumentNullException(nameof(name)),
              (_, null) => throw new ArgumentNullException(nameof(selector)),
              (_, _) => new Doctor(name, selector)
          };
        public void Visit(IElement el)
        {
            Func<string> operation = _selector(el);
            Console.WriteLine($"Doctor: {Name}: {DoctorOperation()} => Name: {el.Name}: {operation()}");
        }
    }

}
