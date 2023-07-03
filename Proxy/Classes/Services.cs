using HelperLib;
using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy.Classes
{
    class ServiceA : IService
    {
        bool FirstTime = true;
        public void Operate()
        {
            if (FirstTime)
            {
                Console.WriteLine("Loading ServiceA...");
                FirstTime = false;
            }
            
            Console.WriteLine("ServiceA");
        } 
    }

    class ServiceB : IService
    {
        bool FirstTime = true;
        public void Operate()
        {
            if (FirstTime)
            {
                Console.WriteLine("Loading ServiceB...");
                FirstTime = false;
            }

            Console.WriteLine("ServiceB");
        }
    }

    class ServiceC : IService
    {
        bool FirstTime = true;
        public void Operate()
        {
            if (FirstTime)
            {
                Console.WriteLine("Loading ServiceC...");
                FirstTime = false;
            }

            Console.WriteLine("ServiceC");
        }
    }
    class NullService : IService
    {
        public void Operate() => Console.WriteLine("no such service");
    }
    class ServiceFactory
    {
        public static IService Create(string optionStr)
            => Helper.GetSelectingChar(optionStr) switch
            {
                'a' => new ServiceA(),
                'b' => new ServiceB(),
                'c' => new ServiceC(),
                _ => new NullService()
            };
    }
}
