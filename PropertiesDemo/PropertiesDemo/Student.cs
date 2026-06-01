// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Properties Demo
// Purpose: Learning about properties

using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassDemo
{
    class Student
    {
        // Fields
        // public static string[] majors = new string[] { "Programming", "Business", "Art History" }; This was used for the static variable demo, it will not be used in this demo
        
        // Auto implemented properties
        public string Major { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StudentNumber { get; set; }
        public double Average { get; private set; }

        // Fully defined properties where setters also calculate average
        private int score1;
        public int Score1 
        {
            get { return score1; }
            set { score1 = value; Calc(); }
        }
        private int score2;
        public int Score2
        {
            get { return score2; }
            set { score2 = value; Calc(); }
        }
        private int score3;
        public int Score3 
        {
            get { return score3; }
            set { score3 = value; Calc(); }
        }

        public Student()
        {
            // empty body - This was created in the initial demo, it should function the same as a default constructor
        }

        // ToString override method (previously GetSummary)
        public override string ToString()
        {
            return "\nStudent Name: " + FirstName + " " + LastName + "\nStudent#: " + StudentNumber + "\nMajor: " + Major + "\nAverage: " + $"{Average:N2}";
        }
        // Calc method
        private void Calc()
        {
            Average = (score1 + score2 + score3) / 3.0;
        }
    }
}
