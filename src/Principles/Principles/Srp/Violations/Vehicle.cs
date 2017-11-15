namespace Principles.Srp.Violations
{
    public class Vehicle
    {
        private readonly int _maxFuel;
        private int _remainingFuel;

        public Vehicle(int maxFuel)
        {
            _maxFuel = maxFuel;
            _remainingFuel = maxFuel;
        }

        public Vehicle(int maxFuel, int remainingFuel)
            : this(maxFuel)
        {
            _remainingFuel = remainingFuel;
        }

        public void Refuel() => _remainingFuel = _maxFuel;
        public int GetMaxFuel() => _maxFuel;
        public int GetRemainingFuel() => _remainingFuel;
        public void SetRemainingFuel(int remainingFuel) => _remainingFuel = remainingFuel;
        public void Accelerate() => _remainingFuel--;
    }
}