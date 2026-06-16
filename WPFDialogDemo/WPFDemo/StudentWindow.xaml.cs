using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class StudentWindow : Window
    {
        private Student st;

        public Student ST 
        {
            get { return st; }
            set { st = value; }
        }
        // Constructors
        public StudentWindow() : this(new Student())
        {
        }

        public StudentWindow(Student st) 
        {
            InitializeComponent();
            this.st = st;
        }

        // Handling click of submit button in student window
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            //Set the values from our controls into the class
            st.FirstName = txbFirstName.Text;
            st.LastName = txbLastName.Text;
            st.StudentNumber = txbStudentNum.Text;
            st.Major = txbMajor.Text;

            // Intialize a list for the scores in the list box, then add them one by one
            List<Assignment> scores = new List<Assignment>();
            foreach (Assignment score in lbScores.Items)
            {
                scores.Add(score);    
            }
            st.Scores = scores;

            // Setting result to true so a success message is shown (and the student is added), then closes the window
            this.DialogResult = true;
            this.Close();

        }

        // Handling click of add button for the score list box
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            
            // Creating an assign object to hold score & title, and adding it to the LB list and the scores list
            Assignment assign = new Assignment();
            assign.Title = txbTitle.Text;
            assign.Score = int.Parse(txbScore.Text);
            st.Scores.Add(assign);
            lbScores.Items.Add(assign);
        }

        // Handling click of cancel button
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            // Sets result to false so the user sees a cancelled message, then closes the window
            DialogResult = false;
            Close();
        }

        // I decided to add a button to remove scores when editing a student
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            // Getting the object from the list box and casting it back into an assignemnt object, then removing it from the LB and the student scores list
            Assignment score = (Assignment) lbScores.SelectedItem;
            st.Scores.Remove(score);
            lbScores.Items.Remove(score);
        }
    }
}
