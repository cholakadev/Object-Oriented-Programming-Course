namespace Vehicles.Core
{
    using System;
    using System.Linq;
    using Vehicles.Models;

    public class Engine
    {
        public void Run()
        {
            string[] carInfo = Console.ReadLine()
                .Split()
                .ToArray();

            string[] truckInfo = Console.ReadLine()
                .Split()
                .ToArray();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);

            Car car = new Car(carFuelQuantity, carFuelConsumption);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption);

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] inputInfo = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = inputInfo[0];
                string vehicleType = inputInfo[1];
                double value = double.Parse(inputInfo[2]);

                if (command == "Drive")
                {
                    if (vehicleType == "Car")
                    {
                        car.Drive(value);
                    }

                    if (vehicleType == "Truck")
                    {
                        truck.Drive(value);
                    }
                }

                else if (command == "Refuel")
                {
                    if (vehicleType == "Car")
                    {
                        car.Refuel(value);
                    }

                    if (vehicleType == "Truck")
                    {
                        truck.Refuel(value);
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }
    }
}
