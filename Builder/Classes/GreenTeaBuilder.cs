using BeverageNS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BeverageNS.Interfaces.AbstractBeverageBuilder;


namespace BeverageNS.Classes
{
    public class GreenTeaBuilder : AbstractBeverageBuilder
    {
        protected override void GetPropotions()
        {
            proportion[Ingredient.Water] = 0.9;
            proportion[Ingredient.Milk] = 0.0;
            proportion[Ingredient.Sugar] = 0.0;
            proportion[Ingredient.Powder] = 0.1;
        }
        public override void SetPowder()
        {
            Console.WriteLine("Adding green tea powder");
            beverage.Powder = beverage.Amount * proportion[Ingredient.Powder];
        }
        public override void SetType()
        {
            Console.WriteLine("Green Tea");
            beverage.Name = "Green Tea";
        }
    }
}
