namespace Vehicles.Core
{
    using System;
    using System.Linq;
    using VehicleExtension.Models;
    using VehiclesExtension.Models;

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

            string[] busInfo = Console.ReadLine()
                .Split()
                .ToArray();

            double carFuelQuantity = double.Parse(carInfo[1]);
            double carFuelConsumption = double.Parse(carInfo[2]);
            double carTankCapacity = double.Parse(carInfo[3]);

            double truckFuelQuantity = double.Parse(truckInfo[1]);
            double truckFuelConsumption = double.Parse(truckInfo[2]);
            double truckTankCapacity = double.Parse(truckInfo[3]);

            double busFuelQuantity = double.Parse(busInfo[1]);
            double busFuelConsumption = double.Parse(busInfo[2]);
            double busTankCapacity = double.Parse(busInfo[3]);

            Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, carTankCapacity);
            Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);


            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                try
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

                        else if (vehicleType == "Truck")
                        {
                            truck.Drive(value);
                        }

                        else if (vehicleType == "Bus")
                        {
                            bus.Drive(value);
                        }
                    }

                    else if (command == "Refuel")
                    {
                        if (vehicleType == "Car")
                        {
                            car.Refuel(value);
                        }

                        else if (vehicleType == "Truck")
                        {
                            truck.Refuel(value);
                        }

                        else if (vehicleType == "Bus")
                        {
                            bus.Refuel(value);
                        }
                    }

                    else if (command == "DriveEmpty")
                    {
                        bus.isEmpty = true;
                        bus.Drive(value);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
                
            }

            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }
    }
}
