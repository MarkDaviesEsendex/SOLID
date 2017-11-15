namespace Principles.Lsp.Example
{
    public class Car : Vehicle
    {
        public override void ChangeGear(Gear gear)
        {
            var actualGear = GetGear();

            if (IsMovingForwards(gear, actualGear) || IsMovingBackwards(gear, actualGear))
                Stop();

            base.ChangeGear(gear);
        }

        private bool IsMovingBackwards(Gear gear, Gear actualGear) => IsMoving() && Gear.R.Equals(actualGear) && Gear.D.Equals(gear);
        private bool IsMovingForwards(Gear gear, Gear actualGear) => IsMoving() && Gear.D.Equals(actualGear) && Gear.R.Equals(gear);
    }
}