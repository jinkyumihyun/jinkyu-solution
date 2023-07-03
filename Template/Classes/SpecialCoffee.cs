using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Interfaces;

namespace Template.Classes
{
    public class SpecialCoffee : AbstractCoffee
    {
        protected override void GetProportions(double totalAmount)
        {
            if (totalAmount <= 0.0)
                throw new ArgumentException("totalAmount <= 0");

            (amount[CoffeeIngredient.Water], amount[CoffeeIngredient.Milk],
             amount[CoffeeIngredient.Sugar], amount[CoffeeIngredient.Powder])
            = (totalAmount * 0.60, totalAmount * 0.1, totalAmount * 0.2, totalAmount * 0.1);
        }
        protected override void AddSugar() 
            => Console.WriteLine($"{amount[CoffeeIngredient.Sugar]} g of Sugar Added");
        protected override void AddCoffeePowder() 
            => Console.WriteLine($"{amount[CoffeeIngredient.Powder]} g of Special Coffee Powder Added");
    }
}
