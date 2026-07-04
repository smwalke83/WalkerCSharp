// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: Program.cs

// Since I didn't write most of this code, I won't fill it with comments about how it works. My only comments are where I made changes to the code. 
// I believe there were only four changes:
    // Employee.cs - The abstract employee class was not public, but it needed to be for the children to access it from outside the class
    // HourlyEmployee.cs - The PaySummary property was not overriding the PaySummary virtual property from Employee.cs
    // SalaryEmployee.cs - The overloaded constructor wasn't assigning the salary parameter to the Salary property.
    // SalaryEmployee.cs - The ToString() method was not overriding the base ToString() method.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee hourEmp = new HourlyEmployee("Bill", "Gates", 15.0M,
                "111-1111", "gatesb@aserver.net");
            hourEmp.Hours.Add(80.0);
            hourEmp.Hours.Add(90.0);
            hourEmp.Hours.Add(70.0);

            DisplayEmployeeInfo(hourEmp, 0, 3);

            SalaryEmployee salaryEmp = new SalaryEmployee("Alan", "Turing", 40000.0M,
                "222-2222", "turinga@aserver.net");
            salaryEmp.Hours.Add(80.0);
            salaryEmp.Hours.Add(80.0);
            salaryEmp.Hours.Add(80.0);

            DisplayEmployeeInfo(salaryEmp, 0, 3);

            Department dep = new Department("Sales Department", salaryEmp, "The start of all problems",
                "333-3333", "sales@aserver.net", "www.amazon.com");

            PhoneBook pb = new PhoneBook();
            pb.PhoneBookEntries.Add(hourEmp);
            pb.PhoneBookEntries.Add(salaryEmp);
            pb.PhoneBookEntries.Add(dep);

            Console.WriteLine(pb.GetPhoneBook());
        }

        private static void DisplayEmployeeInfo(Employee emp, int PayStart, int PayEnd)
        {
            Console.WriteLine(emp.ToString());
            Console.WriteLine(emp.PaySummary);
            Console.WriteLine("Pay for periods " + PayStart + "-" + PayEnd + ": "
                + emp.Pay(PayStart, PayEnd).ToString("c"));
            Console.WriteLine();
        }
    }
}