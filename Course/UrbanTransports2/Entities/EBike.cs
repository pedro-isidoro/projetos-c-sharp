using System.Globalization;
using UrbanTransports2.Entities;

namespace UrbanTransports2.Entities
{
    internal class EBike : AbstractVehicle
    {
        public double BatteryChargeCost { get; set; }
        public double TripsPerDay { get; set; }

        public override double OperationalCost()
        {
            return BatteryChargeCost * TripsPerDay;
        }
        public override string ToString()
        {
            return $"Model: {Model}, Cost: R$ {OperationalCost().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
