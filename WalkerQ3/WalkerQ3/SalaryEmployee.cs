// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: SalaryEmployee.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public SalaryEmployee()
            : this("", "", 30000.0M)
        {
        }

        public SalaryEmployee(string firstName, string lastName, decimal salary, string phone = "TBD", string email = "TBD")
            : base(firstName, lastName, phone, email)
        {
            // SW - Added assignment of salary to class property
            Salary = salary;
        }

        public override string PaySummary
        {
            get
            {
                return "This employee is payed " + Salary + " per year";
            }
        }

        public override decimal Pay(int start, int end)
        {
            const int payPeriodsPerYear = 24;
            decimal pay = Salary * (end - start) / payPeriodsPerYear;
            return pay;
        }

        // SW - The ToString method now properly overrides the ToString() base method.
        public override string ToString()
        {
            return base.ToString() + " Salary Employee";
        }
    }
}
