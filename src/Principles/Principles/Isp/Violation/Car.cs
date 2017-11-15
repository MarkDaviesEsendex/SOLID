namespace Principles.Isp.Violation
{
    public class Car : Vehicle
    {
        private bool _radioOn;

        public Car(bool engineRunning) 
            : base(engineRunning)
        {
        }

        public override void TurnRadioOn()
        {
            _radioOn = true;
        }

        public override void TurnRadioOff()
        {
            _radioOn = false;
        }

        public override void TurnCameraOn()
        {
        }

        public override void TurnCameraOff()
        {
        }
    }
}