// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Student Class Demo
// Purpose: Learning about classes

using StudentClassDemo;

namespace StudenClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string doAnother;
            do
            {
                Student student = new Student();
                string firstName = GetInput("First Name: ");
                student.SetStudentFirstName(firstName);
                string lastName = GetInput("Last Name: ");
                student.SetStudentLastName(lastName);
                // string major = GetInput("Major: "); // These two lines have been commented out to add code for the Static Class Members Demo, seen below
                // student.SetMajor(major);
                Console.WriteLine("Majors: ");
                for (int i = 0; i < Student.majors.Length; i++)
                {
                    Console.WriteLine((i + 1).ToString() + ". " + Student.majors[i]);
                }
                int majorIndex = int.Parse(GetInput("Major: ")) - 1;
                student.SetMajor(Student.majors[majorIndex]);
                // This is the end of the new code added from the new Demo
                string studentNum = GetInput("Student Number: ");
                student.SetStudentNumber(studentNum);
                int score1 = int.Parse(GetInput("Score 1: "));
                student.SetScore1(score1);
                int score2 = int.Parse(GetInput("Score 2: "));
                student.SetScore2(score2);
                int score3 = int.Parse(GetInput("Score 3: "));
                student.SetScore3(score3);

                Console.WriteLine(student.GetSummary());

                doAnother = GetInput("\nDo another? y/n: ");
            } while (doAnother == "y");
        }

        private static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
