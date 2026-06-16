using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for SchoolWindow.xaml
    /// </summary>
    public partial class SchoolWindow : Window
    {
        // Initializing school object
        School school = new School();       
        
        // Constructor creates the window and assigns lists to the list boxes from the school object
        public SchoolWindow()
        {
            InitializeComponent();
            lbCampuses.ItemsSource = school.Campuses;
            lbCourses.ItemsSource = school.Courses;
            lbMajors.ItemsSource = school.Majors;
            lbStudents.ItemsSource = school.Students;
        }

        // Handling click of add student button
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // Intializing student for the new student, and passing it to student window constructor, then showing the window
            Student newStudent = new Student();
            StudentWindow studentWindow = new StudentWindow(newStudent);
            studentWindow.ShowDialog();

            // If the dialog result is true (user clicked submit), shows a success message and adds the student to the student list once the student window is closed
            if (studentWindow.DialogResult == true)
            {
                MessageBox.Show("Student " + newStudent.StudentNumber + " Added!");
                school.Students.Add(newStudent);
                lbStudents.Items.Refresh();
            }
            // If the dialog result is false (user clicked cancel), shows a cancel message once the student window is closed
            else 
            {
                MessageBox.Show("Dialog Cancelled!");
            }
        }

        // Handling click of save student list button
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            // Creates a save file dialog object
            SaveFileDialog saveFile = new SaveFileDialog();
            
            // If save file window is open, create a streamwriter to write to the file, and write each student in the student list to a line
            if (saveFile.ShowDialog() == true) 
            {
                using (StreamWriter file = new StreamWriter(saveFile.OpenFile())) 
                {
                    foreach (var student in school.Students) 
                    {
                        file.WriteLine(student.ToString());
                    }
                }
            }
        }

        // Handling double click of student in student list - This allows the user to edit students in the student list
        private void lbStudents_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            
            // If they clicked on a valid item in the list...
            if (lbStudents.SelectedItem != null) 
            {
                // Getting the item the user selected, casting it back to a Student object, and creating a student window with that object
                Student newStudent = (Student) lbStudents.SelectedItem;
                StudentWindow studentWindow = new StudentWindow(newStudent);

                // Populating each field in the student window with the values from the selected Student object, then refreshing the list
                studentWindow.txbFirstName.Text = newStudent.FirstName;
                studentWindow.txbLastName.Text = newStudent.LastName;
                studentWindow.txbStudentNum.Text = newStudent.StudentNumber;
                studentWindow.txbMajor.Text = newStudent.Major;
                foreach (Assignment score in newStudent.Scores) 
                {
                    studentWindow.lbScores.Items.Add(score);
                }
                studentWindow.lbScores.Items.Refresh();
                studentWindow.ShowDialog();

                // If the user changes values in the above fields, the values will be changed when the user clicks submit or discarded when the user clicks cancel
                if (studentWindow.DialogResult == true)
                {
                    MessageBox.Show("Student " + newStudent.StudentNumber + " Added!");
                    lbStudents.Items.Refresh();
                }
                else
                {
                    MessageBox.Show("Dialog Cancelled!");
                }
            }
        }

        private void btnAddCampus_Click(object sender, RoutedEventArgs e)
        {
            if (txbAddCampus.Text.Length > 0)
            {
                school.Campuses.Add(txbAddCampus.Text);
                lbCampuses.Items.Refresh();
            }
            txbAddCampus.Text = "";
        }

        private void btnRemoveCampus_Click(object sender, RoutedEventArgs e)
        {
            if (lbCampuses.SelectedItem != null)
            {
                school.Campuses.Remove((string)lbCampuses.SelectedItem);
                lbCampuses.Items.Refresh();
            }
        }

        private void btnAddMajor_Click(object sender, RoutedEventArgs e)
        {
            if (txbAddMajor.Text.Length > 0)
            {
                school.Majors.Add(txbAddMajor.Text);
                lbMajors.Items.Refresh();
            }
            txbAddMajor.Text = "";
        }

        private void btnRemoveMajor_Click(object sender, RoutedEventArgs e)
        {
            if (lbMajors.SelectedItem != null)
            {
                school.Majors.Remove((string)lbMajors.SelectedItem);
                lbMajors.Items.Refresh();
            }
        }

        private void btnAddCourse_Click(object sender, RoutedEventArgs e)
        {
            if (txbAddCourse.Text.Length > 0)
            {
                school.Courses.Add(txbAddCourse.Text);
                lbCourses.Items.Refresh();
            }
            txbAddCourse.Text = "";
        }

        private void btnRemoveCourse_Click(object sender, RoutedEventArgs e)
        {
            if (lbCourses.SelectedItem != null)
            {
                school.Courses.Remove((string)lbCourses.SelectedItem);
                lbCourses.Items.Refresh();
            }
        }
    }
}
