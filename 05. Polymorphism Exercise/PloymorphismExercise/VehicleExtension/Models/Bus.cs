namespace VehicleExtension.Models
{
    using System;
    using VehiclesExtension.Models;
    public class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public bool isEmpty { get; set; }

        public override void Drive(double distance)
        {
            if (!isEmpty)
            {
                this.FuelConsumption = base.FuelConsumption + 1.4;
            }

            if (this.FuelQuantity >= this.FuelConsumption * distance)
            {
                base.Drive(distance);
                Console.WriteLine($"Bus travelled {distance} km");
            }

            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }

        public override void Refuel(double amount)
        {
            if (amount <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }

            else
            {
                base.Refuel(amount);
            }
        }
    }
}
