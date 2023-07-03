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
    public class Composite : IComposite
    {
        private List<IComp> ChildComponents = new List<IComp>();
        public string Name { get; }
        public Composite(string name)
            => Name = Helper.IsNullWhite(name) ?? throw new ArgumentException(nameof(name));
        public void AddComponent(IComp NewComponent) 
            => this.ChildComponents.Add(NewComponent ?? throw new ArgumentNullException(nameof(NewComponent)));
        public void RemoveComponent(IComp RemoveComponent) => this.ChildComponents.Remove(RemoveComponent);
        public int GetSalary()
        {
             int Salary = this.ChildComponents.Sum(x => x.GetSalary());
            Console.WriteLine($"Name: Composite: Salary: {Salary}\n");
            return Salary;
        }
    }
}
