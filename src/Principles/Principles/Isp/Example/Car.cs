namespace Principles.Isp.Example
{
    public class Car : Vehicle, IRadioSwitch
    {
        private static bool RadioOn { get; set; }

        public Car(bool engineRunning) : base(engineRunning)
        {
        }

        public void TurnRadioOn()
        {
            RadioOn = true;
        }

        public void TurnRadioOff()
        {
            RadioOn = false;
        }
    }
}