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
                // Need to find proper calculation
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
