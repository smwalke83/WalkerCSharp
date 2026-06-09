// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Object Class Demo

using HRManager;

// Creating employee parent class object and hourly employee child class object, setting properties and calling methods
Employee emp = new Employee();
emp.EmpNum = 1;
emp.FirstName = "Steve";
emp.LastName = "Jobs";
Console.WriteLine("emp.GetHashCode: " + emp.GetHashCode());
Console.WriteLine("emp.GetType: " + emp.GetType());
Console.WriteLine("emp.ToString: " + emp.ToString());
//Console.WriteLine("emp.GetPaySummary: " + emp.PaySummary); This was used in the previous demo but not this one

HourlyEmployee hourEmp = new HourlyEmployee();
hourEmp.EmpNum = 2;
hourEmp.FirstName = "Bill";
hourEmp.LastName = "Gates";
hourEmp.HourlyRate = 15.00M;
Console.WriteLine("hourEmp.GetHashCode: " + hourEmp.GetHashCode());
Console.WriteLine("hourEmp.GetType: " + hourEmp.GetType());
Console.WriteLine("hourEmp.ToString: " + hourEmp.ToString());
//Console.WriteLine("hourEmp.GetPaySummary: " + hourEmp.PaySummary); not used in this demo

//Boxing
Object athing = hourEmp;
Console.WriteLine("hourEmp.ToString: " + athing);

//Unboxing
if (athing is HourlyEmployee) 
{
    HourlyEmployee unboxedEmp = (HourlyEmployee) athing;
    Console.WriteLine("First Name: " + unboxedEmp.FirstName);
}

if (athing is SalaryEmployee) 
{
    SalaryEmployee unboxedEmp = (SalaryEmployee)athing;
    Console.WriteLine("First Name: " + unboxedEmp.FirstName);
}



/* Below code is not used in this demo
Employee emp2 = hourEmp;
Console.WriteLine("emp2.ToString: " + emp2.ToString());
Console.WriteLine("emp2.GetPaySummary: " + emp2.PaySummary);
*/
