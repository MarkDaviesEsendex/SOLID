namespace Principles.Srp.Examples
{
    public class Vehicle
    {
        private readonly int _maxFuel;
        private readonly int _remainingFuel;

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

        public int GetMaxFuel() => _maxFuel;
        public int GetRemainingFuel() => _remainingFuel;
        public Vehicle SetRemainingFuel(int remainingFuel) => new Vehicle(_maxFuel, remainingFuel);
        public Vehicle Accelerate() => new Vehicle(_maxFuel, _remainingFuel-1);
    }
}