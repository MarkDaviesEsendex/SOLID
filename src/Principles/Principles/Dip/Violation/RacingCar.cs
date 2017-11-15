namespace Principles.Dip.Violation
{
    public class RacingCar
    {
        private readonly int _maxFuel;
        private int _remainingFuel;
        private int _power;

        public RacingCar(int maxFuel)
        {
            _maxFuel = maxFuel;
            _remainingFuel = _maxFuel;
        }

        public void Accelerate()
        {
            _power++;
            _remainingFuel--;
        }
    }
}