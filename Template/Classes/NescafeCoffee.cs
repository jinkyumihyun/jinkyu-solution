using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Interfaces;

namespace Template.Classes
{
    public class NescafeCoffee : AbstractCoffee
    {
        protected override void GetProportions(double totalAmount)
        {
            if (totalAmount <= 0.0)
                throw new ArgumentException("totalAmount <= 0");

            (amount[CoffeeIngredient.Water], amount[CoffeeIngredient.Milk],
             amount[CoffeeIngredient.Sugar], amount[CoffeeIngredient.Powder])
            = (totalAmount * 0.70, totalAmount * 0.1, totalAmount * 0.05, totalAmount * 0.15);
        }
       
        protected override void AddCoffeePowder() =>
            Console.WriteLine($"{amount[CoffeeIngredient.Powder]} g of Nescafe Coffee Powder Added");
    }
}
