using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClassesDemo
{
    // HourlyEmployee inherits from Employee
    public sealed class HourlyEmployee : Employee
    {
        // Property for hourly pay rate
        public decimal HourlyRate { get; set; }

        // Override of Pay Summary property
        public override string PaySummary
        {
            get
            {
                return "This employee is payed " + HourlyRate + " per hour.";
            }
        }

        // Constructor with names and hourly rate, calls base constructor for names
        public HourlyEmployee(string firstName, string lastName, decimal hourlyRate) : base(firstName, lastName)
        {
            HourlyRate = hourlyRate;
        }

        // Constructor that applies default values
        public HourlyEmployee() : this("", "", 15.0M)
        {
        }

        // Overridden Pay method for hourly employee
        public override decimal Pay(int start, int end)
        {
            double hours = 0;
            for (int day = start; day < end; ++day) 
            {
                hours += Hours[day];
            }
            return (decimal)hours * HourlyRate;
        }

        // Overridden ToString method
        public override string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }
    }
}
