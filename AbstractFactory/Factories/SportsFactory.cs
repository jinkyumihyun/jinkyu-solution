using AbstractFactory.Classes;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class SportsRegularFactory : IVehicleFactory
    {
        public IBike CreateBike() => new SportsRegularBike();
        public ICar CreateCar() => new SportsRegularCar();
    }
    public class SportsElectricFactory : IVehicleFactory
    {
        public IBike CreateBike() => new SportsElectricBike();
        public ICar CreateCar() => new SportsElectricCar();
    }
}
