using BeverageNS.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageNS.Interfaces
{
    public abstract class AbstractBeverageBuilder
    {
        public enum Ingredient { Water, Milk, Sugar, Powder};

        protected Dictionary<Ingredient, double> proportion = new Dictionary<Ingredient, double>();
        
        protected Beverage beverage;
        public void Create(int amount)
        {
            beverage = new Beverage();
            beverage.Amount = amount;
            GetPropotions();
        }
        public Beverage Get()
        {
            return beverage;
        }
        protected abstract void GetPropotions();       
        public abstract void SetType();
        public abstract void SetPowder();
        public virtual void SetWater()
        {
            Console.WriteLine("Boiling water");
            beverage.Water = beverage.Amount * proportion[Ingredient.Water];
        }
        public virtual void SetMilk()
        {
            Console.WriteLine("Adding milk");
            beverage.Milk = beverage.Amount * proportion[Ingredient.Milk];
        }
        public virtual void SetSugar()
        {
            Console.WriteLine("Adding Sugar");
            beverage.Sugar = beverage.Amount * proportion[Ingredient.Sugar];
        }
    }
}
