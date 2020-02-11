namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
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
            //bool canDrive = this.FuelQuantity - this.FuelConsumption * distance >= 0;

            //if (canDrive)
            //{
            //    this.FuelQuantity -= this.FuelConsumption * distance;
            //}

            this.FuelQuantity -= this.FuelConsumption * distance;
        }

        public virtual void Refuel(double amount)
        {
            this.FuelQuantity += amount;
        }
    }
}
