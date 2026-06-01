// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Properties Demo
// Purpose: Learning about properties

using StudentClassDemo;

namespace StudenClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize student list and do another variable
            List<Student> students = new List<Student>();
            string doAnother;
            
            // do/while loop to add students to list
            do
            {
                Student st = new Student();
                st.FirstName = GetInput("First Name");
                st.LastName = GetInput("Last Name");
                st.Major = GetInput("Major");
                st.StudentNumber = GetInput("Student Number");
                st.Score1 = int.Parse(GetInput("Score 1"));
                st.Score2 = int.Parse(GetInput("Score 2"));
                st.Score3 = int.Parse(GetInput("Score 3"));
                students.Add(st);
                doAnother = GetInput("\nDo another? y/n: ");
            } while (doAnother == "y");

            // Printout of student information for each student
            Console.WriteLine("Student Averages: ");
            foreach (Student st in students) 
            {
                Console.WriteLine(st.ToString());
            }
        }

        // method to prompt a user for input
        static private string GetInput(string prompt)
        {
            Console.Write(prompt + ": ");
            return Console.ReadLine();
        }
    }
}