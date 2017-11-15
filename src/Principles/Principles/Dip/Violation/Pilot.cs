namespace Principles.Dip.Violation
{
    public class Pilot
    {
        private readonly RacingCar _vehicle;
        public Pilot() => _vehicle = new RacingCar(100);
        public void IncreaseSpeed() => _vehicle.Accelerate();
    }
}