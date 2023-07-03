using BeverageNS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageNS.Classes
{
    public class CoffeeBuilder : AbstractBeverageBuilder
    {
        protected override void GetPropotions()
        {
            proportion[Ingredient.Water] = 0.7;
            proportion[Ingredient.Milk] = 0.1;
            proportion[Ingredient.Sugar] = 0.1;
            proportion[Ingredient.Powder] = 0.1;
        }
        public override void SetPowder()
        {
            Console.WriteLine("Adding coffee powder");
            beverage.Powder = beverage.Amount * proportion[Ingredient.Powder];
        }
        public override void SetType()
        {
            Console.WriteLine("Coffee");
            beverage.Name = "Coffee";
        }
    }
}
