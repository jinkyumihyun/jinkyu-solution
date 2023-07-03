using HelperLib;
using Ordinance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinance.Classes
{
    class SpecialDispenser : IOrdinanceDispenser
    {
        public string Name { get; set; }

        int _numberBullets;
        int _numberShells; 
        readonly int _allowablePoints;
        private SpecialDispenser(int numberBullets, int numberShells, int allowablePoints)
            => (_numberBullets, _numberShells, _allowablePoints) = (numberBullets, numberShells, allowablePoints);     
        public static IOrdinanceDispenser Create(int numberBullets, int numberShells, int allowablePoints)
          => (Helper.IsZeroNegative(numberBullets), Helper.IsZeroNegative(numberShells), Helper.IsZeroNegative(allowablePoints)) switch
          {
              (null, _, _) => throw new ArgumentException(nameof(numberBullets)),
              (_, null, _) => throw new ArgumentException(nameof(numberShells)),
              (_, _, null) => throw new ArgumentException(nameof(allowablePoints)),
              (_, _, _) => new SpecialDispenser(numberBullets, numberShells, allowablePoints)
          };
        public bool DispenseOrdinance(ref int numberBullets, ref int numberShells)
            => throw new NotImplementedException(); //to be implemented later
    }
}

