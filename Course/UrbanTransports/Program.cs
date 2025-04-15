using System;
using System.Globalization;
using UrbanTransports.Entities;
using UrbanTransports.Enums;

namespace UrbanTransports
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Register Vehicle");
            Console.Write("How many vehicles you will register? ");
            int qtt = int.Parse(Console.ReadLine());
            RegisterVehicle registerVehicle = new RegisterVehicle();

            for (int i = 1; i <= qtt; i++) {
                Console.Write("Model(Car, Moto, Bus, Metro, EBike): ");
                VehicleType vehicleModel = Enum.Parse<VehicleType>(Console.ReadLine());
                Console.Write("Cost: ");
                double vehicleCost = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Vehicle vehicle = new Vehicle() { Model = vehicleModel, Capacity = vehicleCost };
                registerVehicle.AddToList(vehicle);
            }
            Console.WriteLine();
            Console.WriteLine("Registered Vehicles:");
            Console.WriteLine();
            Console.WriteLine(registerVehicle);
        }
    }
}
