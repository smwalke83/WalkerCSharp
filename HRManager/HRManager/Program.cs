// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Inheritance Demo

using HRManager;

// Creating employee parent class object and hourly employee child class object, setting properties and calling methods
Employee emp = new Employee();
emp.EmpNum = 1;
emp.FirstName = "Steve";
emp.LastName = "Jobs";
Console.WriteLine("emp.ToString: " + emp.ToString());
Console.WriteLine("emp.GetPaySummary: " + emp.PaySummary);

HourlyEmployee hourEmp = new HourlyEmployee();
hourEmp.EmpNum = 2;
hourEmp.FirstName = "Bill";
hourEmp.LastName = "Gates";
hourEmp.HourlyRate = 15.00M;
Console.WriteLine("hourEmp.ToString: " + hourEmp.ToString());
Console.WriteLine("hourEmp.GetPaySummary: " + hourEmp.PaySummary);

Employee emp2 = hourEmp;
Console.WriteLine("emp2.ToString: " + emp2.ToString());
Console.WriteLine("emp2.GetPaySummary: " + emp2.PaySummary);


