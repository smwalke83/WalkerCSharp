// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Inheritance Demo

using System;
using System.Collections.Generic;
using System.Text;

// Base class for the project with a property that can be overridden
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
    }
}
