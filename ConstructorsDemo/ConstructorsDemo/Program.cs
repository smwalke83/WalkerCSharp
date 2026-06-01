// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Constructors Demo
// Purpose: Learning about constructors

using StudentClassDemo;

namespace StudenClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student myStudent = new Student("S001", "John", "Smith");
            Console.WriteLine("Student Number: {0}", myStudent.StudentNumber);
            Console.WriteLine("First Name: {0}", myStudent.FirstName);
            Console.WriteLine("Last Name: {0}", myStudent.LastName);
            Console.WriteLine("Student Major: {0}", myStudent.Major);

        }

        // method to prompt a user for input, not used in this demo
        static private string GetInput(string prompt)
        {
            Console.Write(prompt + ": ");
            return Console.ReadLine();
        }
    }
}