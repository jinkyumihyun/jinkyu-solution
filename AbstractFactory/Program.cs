using AbstractFactory.Factories;
using AbstractFactory.Interfaces;

namespace AbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test4();
        }

        static void Test4()
        {
            Console.WriteLine("Design pattern: various factories\n");

            Console.WriteLine("Abstract factories");
            IVehicleFactory ordinaryRegularVehicleFactory = new OrdinaryRegularFactory();
            IBike ordinaryRegularBike = ordinaryRegularVehicleFactory.CreateBike();
            ordinaryRegularBike.Ride();
            IVehicleFactory sportsElectricVehicleFactory = new SportsElectricFactory();
            IBike sportsElectricBike = sportsElectricVehicleFactory.CreateBike();
            sportsElectricBike.Ride();
            ICar sportsElectricCar = sportsElectricVehicleFactory.CreateCar();
            sportsElectricCar.Drive();
            Console.WriteLine();

            Console.WriteLine("Type factories");
            ICar car = TypeFactory.CreateCar("ors");
            car.Drive();
            IBike bike = TypeFactory.CreateBike("orb"); 
            bike.Ride();
            bike = TypeFactory.CreateBike("xxx"); //=> NullBike: no output
            bike.Ride();
            Console.WriteLine("Null bike: no output");
            Console.WriteLine();

            Console.WriteLine("Type factories Alternate");
            car = TypeFactory.CreateCarAlt("ors");
            car.Drive();
            bike = TypeFactory.CreateBikeAlt("orb");
            bike.Ride();
            car = TypeFactory.CreateCarAlt("orsxxx");  //null car: no output
            car.Drive();
            Console.WriteLine("Null car: no output");
        }
       
        static void Test1()
        {
            IVehicleFactory ordinaryRegularVehicleFactory = new OrdinaryRegularFactory();
            IBike ordinaryRegularBike = ordinaryRegularVehicleFactory.CreateBike();
            ordinaryRegularBike.Ride();

            IVehicleFactory sportsElectricVehicleFactory = new SportsElectricFactory();
            IBike sportsElectricBike = sportsElectricVehicleFactory.CreateBike();
            sportsElectricBike.Ride();

            ICar sportsElectricCar = sportsElectricVehicleFactory.CreateCar();
            sportsElectricCar.Drive();
        }
    }
}