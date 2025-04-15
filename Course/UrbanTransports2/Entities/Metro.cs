using System.Globalization;
using UrbanTransports2.Entities;

namespace UrbanTransports2.Entities
{
    internal class Metro : AbstractVehicle
    {
        public double ElectricCityCostPerKm { get; set; }
        public double DistancePerDay { get; set; }

        public override double OperationalCost()
        {
            return ElectricCityCostPerKm * DistancePerDay;
        }
        public override string ToString()
        {
            return $"Type: {this.GetType().Name}, Type: {this.GetType().Name}, Model: {Model}, Cost: R$ {OperationalCost().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
