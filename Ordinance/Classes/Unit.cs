using HelperLib;
using Ordinance.Classes;
using Ordinance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinance.Classes
{
    public class Unit
    {
        private Unit(IOrdinanceDispenser dispenser, string unitName)
        {
            (_dispenser, _unitName) = (dispenser, unitName);
            _dispenser.Name = _unitName;
        }
    public static Unit Create(IOrdinanceDispenser dispenser, string unitName)
        => (dispenser, Helper.IsNullWhite(unitName)) switch
        {
            (null, _) => throw new ArgumentNullException(nameof(dispenser)),
            (_, null) => throw new ArgumentException(nameof(unitName)),
            (_, _) => new Unit(dispenser, unitName)
        };
        public Unit? NextUnit { get; set; }
        public IOrdinanceDispenser _dispenser;
        public string _unitName;
        public bool DispenseOrdinance(ref int numberBullets, ref int numberShells) =>
               _dispenser.DispenseOrdinance(ref numberBullets, ref numberShells)
            || (NextUnit is null ? Helper.Write("No more next unit.") 
            : NextUnit.DispenseOrdinance(ref numberBullets, ref numberShells));     
    }

   
}
