using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassesDemo
{
    // Employee parent abstract class
    public abstract class Employee
    {
        // Members inherited by children
        public int EmpNum { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private List<double> hours = new List<double>();

        public List<double> Hours 
        {
            get { return hours; }
            set { hours = value; }
        }

        // Abstract property with getter
        public abstract string PaySummary
        {
            get;
        }

        // Static class member to track employee numbers
        private static int LastEmpNum = 0;

        // Constructor that sets employee number
        public Employee() 
        {
            EmpNum = LastEmpNum++;
        }

        // Overloaded constructor with names
        public Employee(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Abstract Pay method
        public abstract Decimal Pay(int start, int end);

        // Overridden ToString method
        public override string ToString()
        {
            return EmpNum + " " + FirstName + " " + LastName;
        }

    }
}
