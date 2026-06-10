// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Depreciation Form
// File: DepreciationDoubleDeclining.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP4
{
    public class DepreciationDoubleDeclining : DepreciationStraightLine
    {
        // properties inherited from DepreciationStraightLine
        // Override parent's calc method
        protected override void Calc() 
        {
            // Validating that item has lifetime, otherwise division by zero could occur
            if (Lifetime > 0)
            {
                // Calculating the annual depreciation rate and time passed
                decimal annualDep = 2m / Lifetime;
                TimeSpan difference = DateRemovedFromInventory - DateAddedToINventory;
                // As far as I can tell, there is no formula to calulate present value to the day with double declining depreciation, so I am rounding up to the nearest year (perhaps rounding down would be better?). Then, for each year of depreciation I subtract the depreciation amount from the salvage value until salvage value reaches end value
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

        // overriding the ToString method to label this object as a Double Declining object
        public override string ToString()
        {
            return "Double Declining - Title: " + Title + " Start Value: " + StartValue + " End Value: " + EndValue + " Lifetime: " + Lifetime;
        }


    }
}
