using HelperLib;
using Ordinance.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordinance.Classes
{
    class OrdinaryDispenser : IOrdinanceDispenser
    {
        public string Name { get; set; }

        int _stockedNumberBullets;
        int _stockedNumberShells; 
        private OrdinaryDispenser(int numberBullets, int numberShells)
         => (_stockedNumberBullets, _stockedNumberShells) = (numberBullets, numberShells);
        public static IOrdinanceDispenser Create(int numberBullets, int numberShells)
           => (Helper.IsZeroNegative(numberBullets), Helper.IsZeroNegative(numberShells)) switch
           {
               (null, _) => throw new ArgumentException(nameof(numberBullets)),
               (_, null) => throw new ArgumentException(nameof(numberShells)),
               (_, _) => new OrdinaryDispenser(numberBullets, numberShells)
           };
        public bool DispenseOrdinance(ref int numberBullets, ref int numberShells)
        {
            if (numberBullets < 0 || numberShells < 0)
            {
                throw new ArgumentException($"{GetType().Name}.DispenseOrdinance: numberBullets < 0 || numberShells < 0");
            }
          
            Console.WriteLine($"Name: {Name}\nrequested number of bullets: {numberBullets}; requested number of shells: {numberShells};");
            Console.WriteLine($"current bullet stock: {_stockedNumberBullets}; current shell stock: {_stockedNumberShells}");

            bool result = Dispense(ref numberBullets, ref _stockedNumberBullets)
                & Dispense(ref numberShells, ref _stockedNumberShells);
            
            Console.WriteLine($"unfilled request of bullets: {numberBullets}; unfilled request of shells: {numberShells}");
            Console.WriteLine($"current bullet stock: {_stockedNumberBullets}; current shell stock: {_stockedNumberShells}\n");
          
            return result;
        }
        bool Dispense(ref int requestedNumber, ref int storedNumber) 
            => requestedNumber > storedNumber ?         
             (requestedNumber -= storedNumber, storedNumber = 0, false).Item3
           : (storedNumber -= requestedNumber, requestedNumber = 0, true).Item3;      
    } 
}
//System.Reflection.MethodBase.GetCurrentMethod().Name