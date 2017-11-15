namespace Principles.Srp.BetterExample
{
    public class FuelTank
    {
        private readonly int _maxFuel;
        private int _remainingFuel;

        public FuelTank(int maxFuel)
        {
            _maxFuel = maxFuel;
            _remainingFuel = maxFuel;
        }

        public FuelTank(int maxFuel, int remainingFuel)
            : this(maxFuel)
        {
            _remainingFuel = remainingFuel;
        }

        public int GetMaxFuel() => _maxFuel;
        public int GetRemainingFuel() => _remainingFuel;
        public void SetRemainingFuel(int remainingFuel) => _remainingFuel = remainingFuel;
    }
}