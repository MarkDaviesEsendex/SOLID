namespace Principles.Ocp.Violation
{
    public class EventHandler
    {
        private readonly Vehicle _vehicle;

        public EventHandler(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void ChangeDrivingMode(DrivingMode drivingMode)
        {
            switch (drivingMode)
            {
                case DrivingMode.Sport:
                    _vehicle.SetPower(500);
                    _vehicle.SetSuspensionHeight(10);
                    break;
                case DrivingMode.Comfort:
                    _vehicle.SetPower(400);
                    _vehicle.SetSuspensionHeight(20);
                    break;
                default:
                    _vehicle.SetPower(400);
                    _vehicle.SetSuspensionHeight(20);
                    break;
            }
        }
    }
}