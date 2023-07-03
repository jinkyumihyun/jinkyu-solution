using Military.Classes;
using Military.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military.Classes
{
    public class Unit
    {
        private Unit(IOrdinanceDispenser dispenser, string unitName)
            => (Dispenser, UnitName) = (dispenser, unitName);
        public static Unit? Create(IOrdinanceDispenser dispenser, string unitName) 
            => dispenser is null ? throw new Exception("Unit.Create")
            : new Unit(dispenser, unitName);
        public Unit NextUnit { get; set; }
        public IOrdinanceDispenser Dispenser { get; set; }
        public string UnitName { get;  }
        public bool DispenseOrdinance(ref int numberBullets, ref int numberShells) 
            => Dispenser.DispenseOrdinance(ref numberBullets, ref numberShells) 
            || NextUnit.DispenseOrdinance(ref numberBullets, ref numberShells);
    }
}
