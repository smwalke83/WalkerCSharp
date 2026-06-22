using AbstractClassesDemo;

HourlyEmployee hourEmp = new HourlyEmployee("Bill", "Gates", 15.0M);
hourEmp.Hours.Add(80.0);
hourEmp.Hours.Add(90.0);
hourEmp.Hours.Add(70.0);

DisplayEmployeeInfo(hourEmp, 0, 3);

SalaryEmployee salaryEmp = new SalaryEmployee("Alan", "Turing", 40000.0M);
salaryEmp.Hours.Add(80.0);
salaryEmp.Hours.Add(80.0);
salaryEmp.Hours.Add(80.0);


DisplayEmployeeInfo(salaryEmp, 0, 3);

static void DisplayEmployeeInfo(Employee emp, int payStart, int payEnd)
{
    Console.WriteLine(emp.ToString());
    Console.WriteLine(emp.PaySummary);
    Console.WriteLine("Pay for periods " + payStart + "-" + payEnd + ": "
        + emp.Pay(payStart, payEnd).ToString("c"));
    Console.WriteLine();
}

List<Employee> myEmployees = new List<Employee>();
myEmployees.Add(salaryEmp);
myEmployees.Add(hourEmp);
decimal payroll = 0;
foreach (Employee e in myEmployees)
{
    payroll += e.Pay(0, 3);
}
Console.WriteLine("Payroll total for 0-2: " + payroll.ToString());

foreach (Employee employee in myEmployees)
{

    Console.WriteLine("Employee: " + employee);
    if (employee is HourlyEmployee)
    {
        HourlyEmployee hourlyEmp = (HourlyEmployee) employee;
        Console.WriteLine("Hourly rate: " + hourlyEmp.HourlyRate);
    }
    if (employee is SalaryEmployee)
    {
        SalaryEmployee salEmp = employee as SalaryEmployee;
        Console.WriteLine("Salary: " + salEmp.Salary);
    }
}

