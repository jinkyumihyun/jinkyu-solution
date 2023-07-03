using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Interfaces
{
    public abstract class PizzaDecorator
    {
        public abstract Pizza Decorate(Pizza pizza);     
    }
}
