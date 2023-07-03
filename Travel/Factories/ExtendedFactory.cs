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
    public class ExtendedFactory : Factory
    {
        public static new ITravel Get()  //new method hiding Factory.Get
        {
            var travel = Factory.Get();
            if (travel is NullTravel)
            {
                Console.Write("Please Enter Travel Type: c) car travel; otherwise no travel:");
                return Helper.GetSelectingChar(Console.ReadLine()) switch
                {
                    'c' => new CarTravel(),
                    _ => new NullTravel(),
                };
            }
            return travel;
        }
    }
}
