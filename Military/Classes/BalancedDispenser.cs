using Military.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military.Classes
{
    class BalancedDispenser : IOrdinanceDispenser
    {

        int _numberBullets;
        int _numberShells; //equivalent to 1000 bullets
        readonly int _allowablePoints;

        public BalancedDispenser(int numberBullets, int numberShells, int allowablePoints)
            => (_numberBullets, _numberShells, _allowablePoints)
            = (numberBullets, numberShells, allowablePoints);
        public bool DispenseOrdinance(ref int numberBullets, ref int numberShells)
            => throw new NotImplementedException();
    }
}