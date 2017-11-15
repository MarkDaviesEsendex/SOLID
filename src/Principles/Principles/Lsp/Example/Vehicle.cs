namespace Principles.Lsp.Example
{
    public class Vehicle
    {
        private bool _isMoving;
        private Gear _gear;

        public void Move() => _isMoving = true;
        public void Stop() => _isMoving = false;
        public bool IsMoving() => _isMoving;
        public Gear GetGear() => _gear;
        public virtual void ChangeGear(Gear gear) => _gear = gear;
    }
}