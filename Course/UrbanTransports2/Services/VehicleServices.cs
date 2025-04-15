using UrbanTransports2.Entities;
using UrbanTransports2.Enums;

namespace UrbanTransports2.Services
{
    internal class VehicleServices
    {
        public static AbstractVehicle CreateVehicleService(VehicleType type, string model)
        {
            switch (type)
            {
                case VehicleType.Car:
                    return new Car() { Model = model, Capacity = 5, DistancePerDay = 2, FuelCostPerKm = 7 };

                case VehicleType.Moto:
                    return new Moto() { Model = model, Capacity = 2, DistancePerDay = 2, FuelCostPerKm = 5 };

                case VehicleType.Bus:
                    return new Bus() { Model = model, Capacity = 60, DistancePerDay = 30, FuelCostPerKm = 50 };

                case VehicleType.Metro:
                    return new Metro() { Model = model, Capacity = 100, DistancePerDay = 100, ElectricCityCostPerKm = 10 };

                case VehicleType.EBike:
                    return new EBike() { Model = model, Capacity = 1, TripsPerDay = 30, BatteryChargeCost = 2 };

                default:
                    throw new ArgumentException("Invalid vehicle type");
            }
        }
    }
}
