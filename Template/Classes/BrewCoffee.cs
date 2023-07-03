using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template.Interfaces;

namespace Template.Classes
{
    public class BrewCoffee : AbstractCoffee
    {
        protected override void GetProportions(double totalAmount)
        {
            if (totalAmount <= 0.0)
                throw new ArgumentException("totalAmount <= 0");

            (amount[CoffeeIngredient.Water], amount[CoffeeIngredient.Milk],
             amount[CoffeeIngredient.Sugar], amount[CoffeeIngredient.Powder])
            = (totalAmount * 0.80, totalAmount * 0.0, totalAmount * 0.05, totalAmount * 0.15);
        }
        protected override void AddCoffeePowder() =>
            Console.WriteLine($"{amount[CoffeeIngredient.Powder]} g of ground Coffee beans Added");
        public override void PrepareCoffee(double totalAmount)
        {
            GetProportions(totalAmount);

            BoilWater();         
            AddCoffeePowder();
            AddSugar();

            Console.WriteLine(this.GetType().Name + " is Ready");
        }
    }
}

