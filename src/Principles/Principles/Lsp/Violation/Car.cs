using System;

namespace Principles.Lsp.Violation
{
    public class Car : Vehicle
    {
        public override void ChangeGear(Gear gear)
        {
            if (Gear.R.Equals(gear) && GetGear().Equals(Gear.D))
                throw new NotImplementedException($"Can't change to REVERSE gear when {GetGear()} gear is engaged!");
        }
    }
}