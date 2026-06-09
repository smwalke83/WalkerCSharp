// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Inheritance Demo

using System;
using System.Collections.Generic;
using System.Text;

namespace HRManager
{
    // child class of employee w/ override to a property and a method
    public class HourlyEmployee : Employee
    {
        public decimal HourlyRate { get; set; }
        public HourlyEmployee() : base() 
        {
            HourlyRate = 15.0M;
        }

        public override string PaySummary
        {
            get { return "This employee is paid $" + HourlyRate + " per hour."; }
        }

        public override string ToString() 
        {
            return base.ToString() + " Hourly Employee";
        }
    }
}
