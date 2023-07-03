using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeverageNS.Classes
{
    public class Beverage
    {
        public double Amount { get; set; }
        public double Water { get; set; }
        public double Milk { get; set; }
        public double Sugar { get; set; }
        public double Powder { get; set; }
        public string Name { get; set; }

        public void ShowBeverage()
        {
            Console.WriteLine( $"Hot {Name}: [{Water} cc of water, {Milk} cc of milk, {Sugar} g of sugar, {Powder} g of {Name}]\n");
        }
    }
}
