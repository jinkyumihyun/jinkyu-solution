using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.Interfaces
{
    public abstract class AbstractCoffee
    {
        // PrepareCoffee method is the template method
        protected enum CoffeeIngredient { Water, Milk, Sugar, Powder};

        protected Dictionary<CoffeeIngredient, double> amount = new Dictionary<CoffeeIngredient, double>();          
        public virtual void PrepareCoffee(double totalAmount)
        {
            GetProportions(totalAmount);

            BoilWater();
            AddMilk();
            AddSugar();
            AddCoffeePowder();

            Console.WriteLine(this.GetType().Name + " is Ready");
        }

        protected abstract void GetProportions(double totalAmount);     
        protected virtual void BoilWater() =>
            Console.WriteLine($"{amount[CoffeeIngredient.Water]} g of Water Boiled");
        protected virtual void AddMilk() =>
            Console.WriteLine($"{amount[CoffeeIngredient.Milk]} g of Milk Added");
        protected virtual void AddSugar() =>
            Console.WriteLine($"{amount[CoffeeIngredient.Sugar]} g of Sugar Added");
        protected abstract void AddCoffeePowder();
    }
}
