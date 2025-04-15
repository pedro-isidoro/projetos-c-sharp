using System;
using System.Globalization;
using UrbanTransports2.Entities;
using UrbanTransports2.Enums;
using UrbanTransports2.Services;

namespace UrbanTransports
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Register Vehicle");
            Console.Write("Which vehicle you will register? (Car, Moto, Bus, Metro, EBike): ");
            //VehicleType type = Enum.Parse<VehicleType>(Console.ReadLine());
            string input = Console.ReadLine();
            if (!Enum.TryParse<VehicleType>(input, true, out VehicleType type))
            {
                Console.WriteLine("Invalid vehicle type. Try again.");
                return;
            }
            Console.Write("Model: ");
            string vehicleModel = Console.ReadLine();

            //AbstractVehicle vehicle = null;
            VehicleServices services = new VehicleServices();
            try
            {
                AbstractVehicle vehicle = VehicleServices.CreateVehicleService(type, vehicleModel);

                Console.WriteLine();
                Console.WriteLine("Registered Vehicles:");
                Console.WriteLine(vehicle);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

            //switch (type)
            //{
            //    case VehicleType.Car:
            //        vehicle = new Car() { Model = vehicleModel, Capacity = 5, DistancePerDay = 2, FuelCostPerKm = 2 };
            //        break;
            //    case VehicleType.Moto:
            //        vehicle = new Moto() { Model = vehicleModel, Capacity = 2, DistancePerDay = 2, FuelCostPerKm = 1 };
            //        break;
            //    case VehicleType.Bus:
            //        vehicle = new Bus() { Model = vehicleModel, Capacity = 60, DistancePerDay = 30, FuelCostPerKm = 50 };
            //        break;
            //    case VehicleType.Metro:
            //        vehicle = new Metro() { Model = vehicleModel, Capacity = 100, DistancePerDay = 100, ElectricCityCostPerKm = 60 };
            //        break;
            //    case VehicleType.EBike:
            //        vehicle = new EBike() { Model = vehicleModel, Capacity = 1, TripsPerDay = 30, BatteryChargeCost = 20 };
            //        break;
            //    default:
            //        Console.WriteLine("Invalid vehicle type");
            //        break;
            //}

            //Console.WriteLine();
            //Console.WriteLine("Registered Vehicles:");
            //Console.WriteLine(vehicle);
        }
    }
}
