// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Depreciation Form
// File: DepreciationStraightLine.cs

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WalkerP4
{
    public class DepreciationStraightLine
    {
        // fields with getters and setters
        private DateTime dateAddedToInventory;
        public DateTime DateAddedToINventory 
        {
            get { return dateAddedToInventory; }
            set { dateAddedToInventory = value; Calc(); }
        }
        private DateTime dateRemovedFromInventory;
        public DateTime DateRemovedFromInventory 
        {
            get { return dateRemovedFromInventory; }
            set { dateRemovedFromInventory = value; Calc(); }
        }
        private decimal startValue;
        public decimal StartValue
        {
            get { return startValue; }
            set { startValue = value; Calc(); }
        }
        private decimal endValue;
        public decimal EndValue 
        {
            get { return endValue; }
            set { endValue = value; Calc(); }
        }
        private int lifetime;
        public int Lifetime 
        {
            get { return lifetime; }
            set { lifetime = value; Calc(); }
        }
        public decimal SalvageValue { get; set; }
        public string Title { get; set; }

        // overridable calc method
        protected virtual void Calc() 
        {
            // validing that a lifetime over zero exists to avoid dividing by zero, and the calculation wouldn't matter if the item had no estimated lifetime
            if (lifetime > 0)
            {
                // annual dollar value of depreciation is calculated, then the exact time passed in years. The two are multiplied together and subtracted from the start value to get a present salvage value
                decimal annualDep = (startValue - endValue) / lifetime;
                TimeSpan difference = dateRemovedFromInventory - dateAddedToInventory;
                decimal yearsPassed = (decimal)(difference.TotalDays / 365);
                SalvageValue = startValue - (yearsPassed * annualDep);
            }
            else 
            {
                SalvageValue = 0;
            }
        }

        // overriding the ToString method for straight line depreciation
        public override string ToString()
        {
            return "Straight Line - Title: " + Title + " Start Value: " + startValue + " End Value: " + endValue + " Lifetime: " + lifetime;
        }
    }
}
