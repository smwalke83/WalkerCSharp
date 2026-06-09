using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace WalkerP4
{
    public class DepreciationStraightLine
    {
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

        protected virtual void Calc() 
        {
            if (lifetime > 0)
            {
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

        public override string ToString()
        {
            return "Straight Line - Title: " + Title + " Start Value: " + startValue + " End Value: " + endValue + " Lifetime: " + lifetime;
        }
    }
}
