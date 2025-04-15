using System.Globalization;
using UrbanTransports2.Entities;

namespace UrbanTransports2.Entities
{
    internal class Moto : AbstractVehicle
    {
        public double FuelCostPerKm { get; set; }
        public double DistancePerDay { get; set; }

        public override double OperationalCost()
        {
            return FuelCostPerKm * DistancePerDay;
        }
        public override string ToString()
        {
            return $"Model: {Model}, Cost: R$ {OperationalCost().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
