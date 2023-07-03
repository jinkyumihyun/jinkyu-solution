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
    internal class TypeFactory
    {
        private static Dictionary<char, Type> s_travels = new Dictionary<char, Type>
        {
            ['a'] = typeof(AutoTravel),
            ['b'] = typeof(BusTravel),
            ['t'] = typeof(TaxiTravel),
            ['r'] = typeof(TrainTravel),
        };
        public static ITravel Get()
        {
            Console.Write("Please Enter Travel Type: a) auto travel; b) bus travel t) taxi travel r) train travel:");
            char Key = Helper.GetSelectingChar(Console.ReadLine());
            if (s_travels.ContainsKey(Key))
            {
                ITravel travel = Activator.CreateInstance(s_travels[Key], null) as ITravel ?? new NullTravel();
                return travel;
            }
            else
            {
                return new NullTravel();
            }
        }
        
    }
}