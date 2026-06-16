using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFDemo
{
    public class School
    {
        // Changed these from Arrays to Lists to make them mutable
        private List<String> courses;
        private List<String> majors;
        private List<String> campuses;
        private List<Student> students;

        public List<String> Courses 
        {
            get { return courses; }
            set { courses = value; }
        }

        public List<String> Majors 
        {
            get { return majors; }
            set { majors = value; }
        }

        public List<String> Campuses 
        {
            get { return campuses; }
            set { campuses = value; }
        }

        public List<Student> Students 
        {
            get { return students; }
            set { students = value; }
        }

        public School() 
        {
            courses = new List<String> { "CIS 101", "CIS 102", "CIS 103", "CIS 104" };
            majors = new List<String> { "Programming", "Web Design", "IT" };
            campuses = new List<String> { "Main", "Montoya", "Rio Rancho" };
            students = new List<Student>();
        }
    }
}
