using Composit.Interfaces;
using HelperLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Composit.Classes
{
    public class Leaf : IComp
    {     
        public string Name { get; }
        public int Salary { get; }
        private Leaf(string Name, int Salary) => (this.Name, this.Salary) = (Name, Salary);
        public static IComp Create(string Name, int Salary)
       => (Helper.IsNullWhite(Name), Helper.IsZeroNegative(Salary)) switch
       {
           (null, _) => throw new ArgumentNullException(nameof(Name)),
           (_, null) => throw new ArgumentException(nameof(Salary)),
           (_, _) => new Leaf(Name, Salary)
       };
        public int GetSalary()
        {
            Console.WriteLine($"Name: {Name}: Salary: {Salary}\n");
            return Salary;
        }
    }
}
