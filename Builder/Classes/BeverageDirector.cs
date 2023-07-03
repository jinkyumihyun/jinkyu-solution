using BeverageNS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageNS.Classes
{
    public class BeverageDirector
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="beverageBuilder"></param>
        /// <returns></returns>
        public Beverage MakeBeverage(AbstractBeverageBuilder beverageBuilder, int amount)
        {
            if (beverageBuilder is null || amount <= 0)
                throw new ArgumentNullException(nameof(beverageBuilder));

            beverageBuilder.Create(amount);
            beverageBuilder.SetType();
            beverageBuilder.SetWater();
            beverageBuilder.SetMilk();
            beverageBuilder.SetSugar();
            beverageBuilder.SetPowder();

            return beverageBuilder.Get();
        }
    }
}
