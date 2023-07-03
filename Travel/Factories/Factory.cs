using HelperLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Classes;
using Travel.Interfaces;

namespace Travel.Factories
{
    public class Factory
    {
        public static ITravel Get()
        {
            Console.Write("Please Enter Travel Type: a) auto travel; b) bus travel t) taxi travel r) train travel:");
            char tavelType = Helper.GetSelectingChar(Console.ReadLine());
            return tavelType switch
            {
                'a' => new AutoTravel(),
                'b' => new BusTravel(),
                't' => new TaxiTravel(),
                'r' => new TrainTravel(),
                _ => new NullTravel(),
            };
        }
    }
}
