namespace Principles.Ocp.Example
{
    public class EventHandler
    {
        private readonly Vehicle _vehicle;

        public EventHandler(Vehicle vehicle)
        {
            _vehicle = vehicle;
        }

        public void ChangeDrivingMode(IDrivingMode drivingMode)
        {
            _vehicle.SetPower(drivingMode.GetPower());
            _vehicle.SetSuspensionHeight(drivingMode.GetSuspensionHeight());
        }
    }
}