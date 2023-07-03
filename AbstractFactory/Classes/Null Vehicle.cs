using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Classes
{
    public class NullBike : IBike
    {
        public void Ride() { }
    }
    public class NullCar : ICar
    {
        public void Drive() { }
    }
}
