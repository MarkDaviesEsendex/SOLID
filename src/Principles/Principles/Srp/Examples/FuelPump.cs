namespace Principles.Srp.Examples
{
    public class FuelPump
    {
        public void RefuelVehicle(Vehicle vehicle)
        {
            var remainingFuel = vehicle.GetRemainingFuel();
            var additionalFuel = vehicle.GetMaxFuel() - remainingFuel;
            vehicle.SetRemainingFuel(remainingFuel + additionalFuel);
        }
    }
}