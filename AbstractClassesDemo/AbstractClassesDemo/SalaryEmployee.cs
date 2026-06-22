using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace AbstractClassesDemo
{
    // Salary Employee inherits from Employee
    public class SalaryEmployee : Employee
    {
        // Property for Salary
        public decimal Salary { get; set; }
        
        // Overridden Pay Summary property
        public override string PaySummary 
        {
            get 
            {
                return "This employee is payed " + Salary + " per year";
            }
        }

        // Constructor with names and salary, calls base constructor from Employee
        public SalaryEmployee(string firstName, string lastName, decimal salary) : base(firstName, lastName) 
        {
            Salary = salary;
        }

        // Constructor that applies default values
        public SalaryEmployee() : this("", "", 30000.0M) 
        {
        }

        // Overridden Pay method for Salary Employee
        public override decimal Pay(int start, int end)
        {
            const int payPeriodsPerYear = 24;
            decimal pay = Salary * (end - start) / payPeriodsPerYear;
            return pay;
        }

        // Overridden To String method
        public override string ToString()
        {
            return base.ToString() + " Salary Employee";
        }
    }
}
