using DP.AbstractFactoryPattern.Implementations;

namespace DP.AbstractFactoryPattern.Contracts
{
    interface IVehicle
    {
        Bike GetBike();
        Car GetCar();
    }
}
