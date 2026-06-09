// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Object Class Demo

using System;
using System.Collections.Generic;
using System.Text;

namespace HRManager
{
    // child class of employee w/ override to a property and a method
    // added some new properties and functions for object class demo
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

        public override decimal Pay(int start, int end)
        {
            double hours = 0;

            for (int day = start; day < end; ++day)
            {
                hours += Hours[day];
            }
            return (decimal)hours * HourlyRate;
        }
    }
}
