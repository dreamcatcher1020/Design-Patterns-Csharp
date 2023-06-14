using DP.AbstractFactoryPattern.Contracts;

namespace DP.AbstractFactoryPattern.Implementations
{
    class Mercedes : IVehicle
    {
        public Bike GetBike()
        {
            return new Bike() { BikeName = "You got Mercedes bike!" };
        }

        public Car GetCar()
        {
            return new Car() { CarName = "You got Mercedes car!" };
        }
    }
}
