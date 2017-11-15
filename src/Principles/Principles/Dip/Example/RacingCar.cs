namespace Principles.Dip.Example
{
    public class RacingCar : IVehicle
    {
        private readonly int _maxFuel;
        private int _remainingFuel;
        private int _power;

        public RacingCar(int maxFuel)
        {
            _maxFuel = maxFuel;
            _remainingFuel = maxFuel;
        }

        public void Accelerate()
        {
            _power++;
            _remainingFuel--;
        }
    }
}