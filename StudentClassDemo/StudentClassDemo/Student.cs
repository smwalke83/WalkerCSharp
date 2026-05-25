using System;
using System.Collections.Generic;
using System.Text;

namespace StudentClassDemo
{
    class Student
    {
        // Fields
        private string major;
        private int score1;
        private int score2;
        private int score3;
        private string studentFirstName;
        private string studentLastName;
        private string studentNumber;
        private float average;

        public Student()
        {
            // empty body
        }

        // Accessors (getters)
        public string GetMajor()
        {
            return major;
        }

        public int GetScore1()
        {
            return score1;
        }

        public int GetScore2()
        {
            return score2;
        }

        public int GetScore3()
        {
            return score3;
        }

        public string GetStudentFirstName()
        {
            return studentFirstName;
        }

        public string GetStudentLastName()
        {
            return studentLastName;
        }

        public string GetStudentNumber()
        {
            return studentNumber;
        }

        // Read-only (getter, no setter)

        public float GetAverage()
        {
            return average;
        }

        public string GetSummary()
        {
            Calc();
            return studentFirstName + " " + studentLastName + " " + studentNumber + " Average: " + average;
        }

        // Mutators (setters)
        public void SetMajor(string newMajor)
        {
            major = newMajor;
        }

        public void SetScore1(int newScore)
        {
            score1 = newScore;
        }

        public void SetScore2(int newScore)
        {
            score2 = newScore;
        }

        public void SetScore3(int newScore)
        {
            score3 = newScore;
        }

        public void SetStudentFirstName(string newName)
        {
            studentFirstName = newName;
        }

        public void SetStudentLastName(string newName)
        {
            studentLastName = newName;
        }

        public void SetStudentNumber(string newNumber)
        {
            studentNumber = newNumber;
        }

        // Private methods

        private void Calc()
        {
            average = (score1 + score2 + score3) / 3;
        }
    }
}
