namespace Vehicles.Models
{
    using System;
    public class Truck : Vehicle
    {
        private const double IncreasedConsumptionByAirCondition = 1.6;

        public Truck(double fuelQuantity, double fuelConsumption) : base(fuelQuantity, fuelConsumption)
        {
            this.FuelConsumption += IncreasedConsumptionByAirCondition;
        }

        public override void Drive(double distance)
        {
            if (this.FuelQuantity >= this.FuelConsumption * distance)
            {
                base.Drive(distance);
                Console.WriteLine($"Truck travelled {distance} km");
            }

            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refuel(double amount)
        {
            amount *= 0.95;
            base.Refuel(amount);
        }
    }
}
