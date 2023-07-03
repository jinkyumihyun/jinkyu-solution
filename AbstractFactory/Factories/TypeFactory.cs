using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.Classes;
using AbstractFactory.Interfaces;

namespace AbstractFactory.Factories
{
    public class TypeFactory
    {
        private static Dictionary<string, Type> s_vehicleDictionary = new Dictionary<string, Type>()
        {
            { "oeb", typeof(OrdinaryElectricBike) },
            { "oec", typeof(OrdinaryElectricCar)},
            { "orb", typeof(OrdinaryRegularBike)},
            { "orc", typeof(OrdinaryRegularCar)},
            { "ors", typeof(OrdinaryRegularSUV)},
            { "seb", typeof(SportsElectricBike)},
            { "sec", typeof(SportsElectricCar)},
            { "srb", typeof(SportsRegularBike)},
            { "src", typeof(SportsRegularCar)},
        };    
        public static IBike CreateBike(string bikeType) => CreateVehicle<IBike, NullBike>(bikeType);
        public static ICar CreateCar(string carType) => CreateVehicle<ICar, NullCar>(carType);
        private static TVehicle  CreateVehicle<TVehicle, TNullVehicle>(string vehicleType) 
            where TVehicle : class 
            where TNullVehicle : TVehicle, new()
        {
            string Key = string.Empty;
            if (!string.IsNullOrWhiteSpace(vehicleType))
            {
                Key = vehicleType.Trim().ToLower();
            }
            Type typeInfo;
            try
            {
                typeInfo = s_vehicleDictionary[Key];
            }
            catch
            {
                return new TNullVehicle();
            }

            return Activator.CreateInstance(typeInfo, null) as TVehicle ?? new TNullVehicle();
        }

        public static ICar CreateCarAlt(string carType)
            => carType switch
            {
                "oec" => new OrdinaryElectricCar(),
                "orc" => new OrdinaryRegularCar(),
                "ors" => new OrdinaryRegularSUV(),
                "sec" => new SportsElectricCar(),
                "src" => new SportsRegularCar(),
                _ => new NullCar()
            };
        public static IBike CreateBikeAlt(string bikeType)
           => bikeType switch
           {
               "oeb" => new OrdinaryElectricBike(),
               "orb" => new OrdinaryRegularBike(),
               "seb" => new SportsElectricBike(),
               "srb" => new SportsRegularBike(),
               _ => new NullBike()
           };

    }
}
