using DP.AbstractFactoryPattern.Implementations;
using System;

namespace DP.AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Honda
            Honda honda = new Honda();
            VehicleFactory vehicleFactoryHonda = new VehicleFactory(honda);

            Bike hondaBike = vehicleFactoryHonda.GetBike();
            Console.WriteLine(hondaBike.BikeName);

            Car hondaCar = vehicleFactoryHonda.GetCar();
            Console.WriteLine(hondaCar.CarName);

            // Mercedes
            Mercedes mercedes = new Mercedes();
            VehicleFactory vehicleFactoryMercedes = new VehicleFactory(mercedes);

            Bike MercedesBike = vehicleFactoryMercedes.GetBike();
            Console.WriteLine(MercedesBike.BikeName);

            Car MercedesCar = vehicleFactoryMercedes.GetCar();
            Console.WriteLine(MercedesCar.CarName);

            Console.ReadLine();
        }
    }
}
