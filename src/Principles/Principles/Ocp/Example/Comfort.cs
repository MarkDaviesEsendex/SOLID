namespace Principles.Ocp.Example
{
    public class Comfort : IDrivingMode
    {
        private const int Power = 400;
        private const int SuspensionHeight = 20;

        public int GetPower() => Power;
        public int GetSuspensionHeight() => SuspensionHeight;
    }
}