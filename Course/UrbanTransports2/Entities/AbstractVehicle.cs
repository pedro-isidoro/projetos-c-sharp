using UrbanTransports2.Enums;

namespace UrbanTransports2.Entities
{
    internal abstract class AbstractVehicle : IVehicle
    {
        public string Model { get; set; }
        public double Capacity { get; set; }

        public abstract double OperationalCost();
    }
}
