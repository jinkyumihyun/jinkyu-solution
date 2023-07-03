using AbstractFactory.Classes;
using AbstractFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factories
{
    public class OrdinaryElectricFactory : IVehicleFactory
    {
        public IBike CreateBike() => new OrdinaryElectricBike();
        public ICar CreateCar() => new OrdinaryElectricCar();      
    }
    public class OrdinaryRegularFactory : IVehicleFactory
    {
        public IBike CreateBike() => new OrdinaryRegularBike();
        public ICar CreateCar() => new OrdinaryRegularCar();
    }
}


