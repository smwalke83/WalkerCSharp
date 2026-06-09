using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP4
{
    public class DepreciationDoubleDeclining : DepreciationStraightLine
    {
        protected override void Calc() 
        {
            if (Lifetime > 0)
            {
                decimal annualDep = 2m / Lifetime;
                TimeSpan difference = DateRemovedFromInventory - DateAddedToINventory;
                // Since this isn't a striaght line calculation, I am rounding the time passed up to the nearest year and calculating based on that (if <1 year passes, it depreciates by 1 year, if it's between 1 and 2 years, then it's treated as 2 years, etc
                int yearsPassed = (int)Math.Ceiling(difference.TotalDays / 365);
                SalvageValue = StartValue;
                for (int i = 0; i < yearsPassed; i++) 
                {
                    if (SalvageValue > EndValue) 
                    {
                        decimal dep = SalvageValue * annualDep;
                        SalvageValue -= dep;
                    }
                    if (SalvageValue < EndValue) 
                    {
                        SalvageValue = EndValue;
                    }
                }
            }
            else
            {
                SalvageValue = 0;
            }
        }

        public override string ToString()
        {
            return "Double Declining - Title: " + Title + " Start Value: " + StartValue + " End Value: " + EndValue + " Lifetime: " + Lifetime;
        }


    }
}
