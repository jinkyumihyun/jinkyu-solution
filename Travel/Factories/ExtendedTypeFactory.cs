using HelperLib;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Travel.Classes;
using Travel.Interfaces;

namespace Travel.Factories
{
    internal class ExtendedTypeFactory : TypeFactory
    {
        private static Dictionary<char, Type> s_travels = new Dictionary<char, Type>
        {
            ['c'] = typeof(CarTravel),
        };

        public static new ITravel Get()
        {
            var travel = TypeFactory.Get();

            if (travel is NullTravel)
            {
                Console.Write("Please Enter Travel Type: c) car travel; otherwise no travel:");
                char Key = Helper.GetSelectingChar(Console.ReadLine());
                if (s_travels.ContainsKey(Key))
                {
                    return Activator.CreateInstance(s_travels[Key], null) as ITravel ?? new NullTravel();
                }
                else
                {
                    return new NullTravel();
                }
            }

            return travel;
        }
    }
}
