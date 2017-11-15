namespace Principles.Isp.Example
{
    public class Vehicle : IEngineSwitch
    {
        private bool _engineRunning;

        public Vehicle(bool engineRunning) => _engineRunning = engineRunning;

        public virtual void StartEngine() => _engineRunning = true;
        public virtual void ShutDownEngine() => _engineRunning = false;
    }
}