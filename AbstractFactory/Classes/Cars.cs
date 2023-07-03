using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public class OrdinaryElectricCar : ICar
    {
        public void Drive() => Console.WriteLine("Driving an OrdinaryElectricCar...");
    }

    public class OrdinaryRegularCar : ICar
    {
        public void Drive() => Console.WriteLine("Driving an OrdinaryRegularCar...");
    }
    public class OrdinaryRegularSUV : ICar
    {
        public void Drive() => Console.WriteLine("Driving an OrdinaryRegularSUV...");
    }
    public class SportsElectricCar : ICar
    {
        public void Drive() => Console.WriteLine("Driving a SportsElectricCar...");
    }
    public class SportsRegularCar : ICar
    {
        public void Drive() => Console.WriteLine("Driving a SportsRegularCar...");
    }
}
