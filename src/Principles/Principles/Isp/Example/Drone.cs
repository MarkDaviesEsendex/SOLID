namespace Principles.Isp.Example
{
    public class Drone : Vehicle, ICameraSwitch
    {
        private bool CameraOn { get; set; }

        public Drone(bool engineRunning) 
            : base(engineRunning)
        {
        }

        public void TurnCameraOn() => CameraOn = true;

        public void TurnCameraOff() => CameraOn = false;
    }
}