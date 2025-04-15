using System;
using System.Globalization;

namespace UrbanTransports.Entities
{
    internal class RegisterVehicle : Vehicle
    {

        public override double OperationalCost()
        {
            double total = 0.0;
            foreach (Vehicle vehicle in Vehicles)
            {
                total += vehicle.Capacity;
            }
            return total;
        }

        public override string ToString()
        {
                return ($"Model: {Model}, Cost: R$ {Capacity.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
