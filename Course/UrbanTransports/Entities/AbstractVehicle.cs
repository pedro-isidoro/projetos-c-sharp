using UrbanTransports.Enums;

namespace UrbanTransports.Entities
{
    internal abstract class AbstractVehicle : IVehicle
    {
        public VehicleType Model { get; set; }
        public double Capacity { get; set; }

        public abstract double OperationalCost();
    }
}
