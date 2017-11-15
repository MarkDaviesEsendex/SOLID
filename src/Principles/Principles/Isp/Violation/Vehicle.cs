namespace Principles.Isp.Violation
{
    public abstract class Vehicle : ISwitches
    {
        private bool _engineRunning;

        protected Vehicle(bool engineRunning) => _engineRunning = engineRunning;

        public virtual void StartEngine() => _engineRunning = true;
        public virtual void ShutDownEngine() => _engineRunning = false;

        public abstract void TurnRadioOn();
        public abstract void TurnRadioOff();
        public abstract void TurnCameraOn();
        public abstract void TurnCameraOff();
    }
}