﻿using Decorator.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Classes
{
    public class ChickenPizzaDecorator : PizzaDecorator
    {
        public override Pizza Decorate(Pizza pizza)
        {
            pizza.toppings.Add("Chicken");
            return pizza;
        }

    }
}
