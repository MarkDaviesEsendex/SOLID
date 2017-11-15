namespace Principles.Isp.Violation
{
    public interface ISwitches
    {
        void StartEngine();
        void ShutDownEngine();
        void TurnRadioOn();
        void TurnRadioOff();
        void TurnCameraOn();
        void TurnCameraOff();
    }
}