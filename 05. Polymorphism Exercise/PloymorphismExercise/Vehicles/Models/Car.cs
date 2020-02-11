namespace Vehicles.Models
{
    using System;
    public class Car : Vehicle
    {
        private const double IncreasedConsumptionByAirCondition = 0.9;
        public Car(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsumption += IncreasedConsumptionByAirCondition;
        }

        public override void Drive(double distance)
        {
            if (this.FuelQuantity >= this.FuelConsumption * distance)
            {
                base.Drive(distance);
                Console.WriteLine($"Car travelled {distance} km");
            }

            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }

        public override void Refuel(double amount)
        {
            base.Refuel(amount);
        }
    }
}
