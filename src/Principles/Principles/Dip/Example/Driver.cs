namespace Principles.Dip.Example
{
    public class Driver
    {
        private readonly IVehicle _vehicle;

        public Driver(IVehicle vehicle) => _vehicle = vehicle;

        public void IncreaseSpeed() => _vehicle.Accelerate();
    }
}