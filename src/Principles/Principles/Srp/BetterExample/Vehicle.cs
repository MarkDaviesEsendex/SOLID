namespace Principles.Srp.BetterExample
{
    public class Vehicle
    {
        private readonly FuelTank _fuelTank;

        public Vehicle(FuelTank fuelTank)
        {
            _fuelTank = fuelTank;
        }

        public int GetMaxFuel() => _fuelTank.GetMaxFuel();
        public int GetRemainingFuel() => _fuelTank.GetRemainingFuel();
        public void SetRemainingFuel(int remainingFuel) => _fuelTank.SetRemainingFuel(remainingFuel);
        public void Accelerate() => _fuelTank.SetRemainingFuel(GetRemainingFuel() - 1);
    }
}