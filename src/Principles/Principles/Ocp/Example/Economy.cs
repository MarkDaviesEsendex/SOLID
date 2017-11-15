namespace Principles.Ocp.Example
{
    public class Economy : IDrivingMode
    {
        private const int Power = 300;
        private const int SuspensionHeight = 20;

        public int GetPower() => Power;
        public int GetSuspensionHeight() => SuspensionHeight;
    }
}