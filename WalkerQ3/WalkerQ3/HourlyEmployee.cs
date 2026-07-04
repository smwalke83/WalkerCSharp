// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: HourlyEmployee.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    public sealed class HourlyEmployee : Employee
    {
        public decimal HourlyRate { get; set; }

        public HourlyEmployee() : this("", "", 15.0M)
        {
        }

        public HourlyEmployee(string firstName, string lastName, decimal hourlyRate, string phone = "TBD", string email = "TBD")
            : base(firstName, lastName, phone, email)
        {
            HourlyRate = hourlyRate;
        }

        // SW - The PaySummary property now properly overrides the virtual PaySummary from the Employee class.
        public override string PaySummary
        {
            get
            {
                return "This employee is payed " + HourlyRate + " per hour";
            }
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

        public override string ToString()
        {
            return base.ToString() + " Hourly Employee";
        }
    }
}
