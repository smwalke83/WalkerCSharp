// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Object Class Demo

using System;
using System.Collections.Generic;
using System.Text;

// Base class for the project with a property that can be overridden
// added some new properties and functions for object class demo
namespace HRManager
{
    public class Employee
    {
        public int EmpNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string PaySummary
        {
            get { return "No pay for base class employee."; }
        }

        public override string ToString() 
        {
            return EmpNum + " " + FirstName + " " + LastName;
        }

        private List<double> hours = new List<double>();

        public List<double> Hours
        {
            get { return hours; }
            set { hours = value; }
        }

        public virtual Decimal Pay(int start, int end)
        {
            return 0;
        }
    }
}
