using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            base.name = this.GetType().Name;
        }
        public override Pizza Decorate(PizzaDecorator decorator)
        {
            decorator.Decorate(this);
            return this;
        }
    }
}
