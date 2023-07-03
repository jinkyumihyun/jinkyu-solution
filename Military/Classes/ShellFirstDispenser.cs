﻿using Military.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Military.Classes
{
    class ShellFirstDispenser : IOrdinanceDispenser
    {
        int _stockedNumberBullets;
        int _stockedNumberShells;

        public ShellFirstDispenser(int numberBullets, int numberShells)
            => (_stockedNumberBullets, _stockedNumberShells) = (numberBullets, numberShells);
        public bool DispenseOrdinance(ref int numberBullets, ref int numberShells)
        {
            if (numberBullets < 0 || numberShells < 0)
            {
                throw new ArgumentException("numberBullets < 0 || numberShells < 0");
            }
           
            Console.WriteLine($"requested number of bullets: {numberBullets}; requested number of shells: {numberShells}");

            bool result = Dispense(ref numberShells, ref _stockedNumberShells)
                & Dispense(ref numberBullets, ref _stockedNumberBullets);

            Console.WriteLine($"unfilled request of bullets: {numberBullets}; unfilled request of shells: {numberShells}");
            Console.WriteLine($"current bullet stock: {_stockedNumberBullets}; current shell stock: {_stockedNumberShells}");

            return result;
        }

      bool Dispense(ref int requestedNumber, ref int storedNumber) 
            => requestedNumber > storedNumber ? 
              (requestedNumber = 0, storedNumber -= requestedNumber, true).Item3
            : (requestedNumber -= storedNumber, storedNumber = 0, false).Item3;
    }
}
