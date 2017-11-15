namespace Principles.Isp.Violation
{
    public class Drone : Vehicle
    {
        private bool _cameraOn;

        public Drone(bool engineRunning) 
            : base(engineRunning)
        {
        }


        public override void TurnRadioOn()
        {
        }

        public override void TurnRadioOff()
        {
        }

        public override void TurnCameraOn()
        {
            _cameraOn = true;
        }

        public override void TurnCameraOff()
        {
            _cameraOn = false;
        }
    }
}