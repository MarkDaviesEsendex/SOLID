namespace Principles.Ocp.Violation
{
    public class Vehicle
    {
        private int _power;
        private int _suspensionHeight;

        public int GetPower() => _power;
        public int GetSuspensionHeight() => _suspensionHeight;
        public void SetPower(int power) => _power = power;
        public void SetSuspensionHeight(int suspensionHeight) => _suspensionHeight = suspensionHeight;
    }
}