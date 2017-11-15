namespace Principles.Lsp.Violation
{
    public class Vehicle
    {
        private Gear _gear;

        public Gear GetGear()
        {
            return _gear;
        }

        public virtual void ChangeGear(Gear gear) => _gear = gear;
    }
}