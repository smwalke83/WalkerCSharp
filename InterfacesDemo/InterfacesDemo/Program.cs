using InterfacesDemo;

// Everything until the department instantiation is from the previous demo

HourlyEmployee hourEmp = new HourlyEmployee(2, "Bill", "Gates", 15.00M);
hourEmp.Hours.Add(80.0);
hourEmp.Hours.Add(90.0);
hourEmp.Hours.Add(70.0);

DisplayEmployeeInfo(hourEmp, 0, 3);

SalaryEmployee salaryEmp = new SalaryEmployee();
salaryEmp.EmpNum = 2;
salaryEmp.FirstName = "Alan";
salaryEmp.LastName = "Turing";
salaryEmp.Salary = 40000.0M;
salaryEmp.Hours.Add(80.0);
salaryEmp.Hours.Add(80.0);
salaryEmp.Hours.Add(80.0);

DisplayEmployeeInfo(salaryEmp, 0, 3);

List<Employee> myEmployees = new List<Employee>();
myEmployees.Add(salaryEmp);
myEmployees.Add(hourEmp);
decimal payroll = 0;
foreach (Employee employee in myEmployees)
{
    payroll += employee.Pay(0, 3);
}
Console.WriteLine("Payroll total for 0-2: " + payroll.ToString());
Console.WriteLine();

foreach (Employee employee in myEmployees)
{

    Console.WriteLine("Employee: " + employee);
    if (employee is HourlyEmployee)
    {
        //HourlyEmployee hourlyEmp = employee as HourlyEmployee;
        HourlyEmployee hourlyEmp = (HourlyEmployee)employee;
        Console.WriteLine("Hourly rate: " + hourlyEmp.HourlyRate);
    }
    if (employee is SalaryEmployee)
    {
        SalaryEmployee salEmp = employee as SalaryEmployee;
        Console.WriteLine("Salary: " + salEmp.Salary);
    }
}

// Here is where this demo starts - Instantiate a department object and a phonebook object

Department dep = new Department("Sales Department");

Phonebook pb = new Phonebook();

// Adding two Employee objects and a Department object to the PhoneBookEntries (which is a list of interface objects; Employee and Department both inherit from this interface)
pb.PhoneBookEntries.Add(hourEmp);
pb.PhoneBookEntries.Add(salaryEmp);
pb.PhoneBookEntries.Add(dep);

// Calling the GetPhoneBook method of PhoneBook, which in turn calls the GetContactSummary method required by the IPhoneBookItem interface
Console.WriteLine(pb.GetPhoneBook());

// Display Employee Info method created in previous demo
static void DisplayEmployeeInfo(Employee emp, int payStart, int payEnd)
{
    Console.WriteLine(emp.ToString());
    Console.WriteLine(emp.PaySummary);
    Console.WriteLine("Pay for periods " + payStart + "-" + payEnd + ": "
        + emp.Pay(payStart, payEnd).ToString("c"));
    Console.WriteLine();
}