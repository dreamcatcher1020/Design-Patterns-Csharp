using DP.AbstractFactoryPattern.Contracts;

namespace DP.AbstractFactoryPattern.Implementations
{
    class Honda : IVehicle
    {
        public Bike GetBike()
        {
            return new Bike() { BikeName = "You got Honda bike!" };
        }

        public Car GetCar()
        {
            return new Car() { CarName = "You got Honda car!" };
        }
    }
}
