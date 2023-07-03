using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public class OrdinaryElectricBike : IBike
    {
        public void Ride() => Console.WriteLine("Riding an OrdinaryElectricBike...");
    }

    public class OrdinaryRegularBike : IBike
    {
        public void Ride() => Console.WriteLine("Riding an OrdinaryRegularBike...");
    }

    public class SportsElectricBike : IBike
    {
        public void Ride() => Console.WriteLine("Riding a SportsElectricBike...");
    }
    public class SportsRegularBike : IBike
    {
        public void Ride() => Console.WriteLine("Riding a SportsRegularBike...");
    }
}
