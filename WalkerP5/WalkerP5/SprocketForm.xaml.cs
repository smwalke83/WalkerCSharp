// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: SprocketForm.xaml.cs

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WalkerP5
{
    /// <summary>
    /// Interaction logic for SprocketForm.xaml
    /// </summary>
    public partial class SprocketForm : Window
    {
        // Sprocket property to be added to the item order
        public Sprocket Sprocket { get; set; }

        // list field for the material types, to be wired to the combo box

        private List<string> types = new List<string> { "Steel", "Aluminum", "Plastic" };
        
        // Constructor, initializes the window, then sets the item source for the combo box and sets the starting index to 0
        public SprocketForm()
        {
            InitializeComponent();
            cbItemType.ItemsSource = types;
            cbItemType.SelectedIndex = 0;
        }

        // Handling clicking the submit button
        private void btnSubmit_Click(object sender, RoutedEventArgs e)
        {
            // try/catch block will catch if user doesn't put in integers
            try
            {
                // If the user selected Steel, creates a steel sprocket based on the input text fields
                if (cbItemType.SelectedIndex == 0)
                {
                    Sprocket = new SteelSprocket(int.Parse(txbItemID.Text), int.Parse(txbNumberOfItems.Text), int.Parse(txbNumberOfTeeth.Text));
                }
                // If the user selected Aluminum, creates an aluminum sprocket based on the input text fields
                else if (cbItemType.SelectedIndex == 1)
                {
                    Sprocket = new AluminumSprocket(int.Parse(txbItemID.Text), int.Parse(txbNumberOfItems.Text), int.Parse(txbNumberOfTeeth.Text));
                }
                // If the user selected Plastic, creates a plastic sprocket based on the input text fields
                else
                {
                    Sprocket = new PlasticSprocket(int.Parse(txbItemID.Text), int.Parse(txbNumberOfItems.Text), int.Parse(txbNumberOfTeeth.Text));
                }
                // Sets dialog result to true (meaning a new sprocket will be added) and closes the window 
                DialogResult = true;
                Close();
            }
            // If there is an error, it is displayed in a message box and nothing is submitted
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex.Message);

            }
            
        }

        // Handling the clicking of the cancel button (set dialog result to false and close the window)
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
            Close();
        }
    }
}
