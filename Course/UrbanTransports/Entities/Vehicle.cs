namespace UrbanTransports.Entities
{
    internal class Vehicle : AbstractVehicle
    {
        public override double OperationalCost()
        {
            return Capacity;
        }
    }
}
