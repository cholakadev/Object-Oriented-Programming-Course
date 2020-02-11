using System;

namespace VehiclesExtension.Models
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double tankCapacity;

        protected Vehicle(double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
            this.TankCapacity = tankCapacity;
        }

        public double TankCapacity
        {
            get { return tankCapacity; }
            private set { tankCapacity = value; }
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            private set { this.fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            protected set { this.fuelConsumption = value; }
        }


        public virtual void Drive(double distance)
        {
            this.FuelQuantity -= this.FuelConsumption * distance;
        }

        public virtual void Refuel(double amount)
        {
            if (this.FuelQuantity + amount > this.TankCapacity)
            {
                throw new InvalidOperationException($"Cannot fit {amount} fuel in the tank");
            }

            if (amount <= 0)
            {
                throw new InvalidOperationException("Fuel must be a positive number");
            }

            else
            {
                this.FuelQuantity += amount;
            }
        }
    }
}
