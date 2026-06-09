// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Object Class Demo

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager
{
    // This class was included for the object class demo. It is only used to practice the "is" operator
    class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }

        public override string PaySummary
        {
            get
            {
                return "This employee is payed " + Salary + " per year.";
            }
        }

        public override decimal Pay(int start, int end)
        {
            const int PAYPERIODSPERYEAR = 24;
            decimal pay = Salary * (end - start) / PAYPERIODSPERYEAR;
            return pay;
        }
    }
}

