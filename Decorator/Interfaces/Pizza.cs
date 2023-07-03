using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Interfaces
{
    public abstract class Pizza
    {
        public List<string> toppings = new List<string>();

        public string name;
        public abstract Pizza Decorate(PizzaDecorator d);
        public override string ToString()
        {
            string s = $"name: {name}; toppings: ";
            toppings.ForEach(t => s += (t + " "));
            return s;
        }
    }
}
