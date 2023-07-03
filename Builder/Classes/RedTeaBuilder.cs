using BeverageNS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BeverageNS.Interfaces.AbstractBeverageBuilder;

namespace BeverageNS.Classes
{
    public class RedTeaBuilder : AbstractBeverageBuilder
    {
        protected override void GetPropotions()
        {
            proportion[Ingredient.Water] = 0.8;
            proportion[Ingredient.Milk] = 0.1;
            proportion[Ingredient.Sugar] = 0.05;
            proportion[Ingredient.Powder] = 0.05;
        }
        public override void SetPowder()
        {
            Console.WriteLine("Adding red tea powder");
            beverage.Powder = beverage.Amount * proportion[Ingredient.Powder];
        }
        public override void SetType()
        {
            Console.WriteLine("Red Tea");
            beverage.Name = "Red Tea";
        }
    }
}
