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
            Console.Write("How vehicle you will register? (Car, Moto, Bus, Metro, EBike)");
            VehicleType type = Enum.Parse<VehicleType>(Console.ReadLine());
            Console.Write("Model: ");
            string vehicleModel = Console.ReadLine();

            //AbstractVehicle vehicle = null;
            VehicleServices services = new VehicleServices();
            AbstractVehicle vehicle = VehicleServices.CreateVehicleService(type, vehicleModel);

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

            Console.WriteLine();
            Console.WriteLine("Registered Vehicles:");
            Console.WriteLine(vehicle);
        }
    }
}
