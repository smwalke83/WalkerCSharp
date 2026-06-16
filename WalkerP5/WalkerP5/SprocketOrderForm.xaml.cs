// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: SprocketOrderForm.xaml.cs

using Microsoft.Win32;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WalkerP5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class SprocketOrderForm : Window
    {
        // Initializing a sprocket order, whose fields are filled in when the save file is created or when sprockets are added
        private SprocketOrder order = new SprocketOrder();
        
        // Constructor assigns the items list from the order as the source for the list box
        public SprocketOrderForm()
        {
            InitializeComponent();
            lbItems.ItemsSource = order.Items;
        }

        // Handling when local pickup is checked - Address fields and text boxes are hidden
        private void cbLocalPickup_Checked(object sender, RoutedEventArgs e)
        {
            lblStreet.Visibility = Visibility.Hidden;
            lblState.Visibility = Visibility.Hidden;
            lblCity.Visibility = Visibility.Hidden;
            lblZip.Visibility = Visibility.Hidden;
            txbStreet.Visibility = Visibility.Hidden;
            txbState.Visibility = Visibility.Hidden;
            txbCity.Visibility = Visibility.Hidden;
            txbZip.Visibility = Visibility.Hidden;
        }

        // Handling when local pickup is unchecked - Address fields and text boxes appear
        private void cbLocalPickup_Unchecked(object sender, RoutedEventArgs e)
        {
            lblStreet.Visibility = Visibility.Visible;
            lblState.Visibility = Visibility.Visible;
            lblCity.Visibility = Visibility.Visible;
            lblZip.Visibility = Visibility.Visible;
            txbStreet.Visibility = Visibility.Visible;
            txbState.Visibility = Visibility.Visible;
            txbCity.Visibility = Visibility.Visible;
            txbZip.Visibility = Visibility.Visible;
        }

        // Handling when user clicks add button
        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            // Creates a sprocket form for the user to interact with. Dialog result is set by buttons clicked in the sprocket form window
            SprocketForm form = new SprocketForm();
            form.ShowDialog();
            // If the dialog result is true (user successfully submitted a sprocket), a success message is displayed and the sprocket is added to the order and the list box
            if (form.DialogResult == true)
            {
                MessageBox.Show("Sprocket " + form.Sprocket.ItemID + " added!");
                order.Add(form.Sprocket);
                lbItems.Items.Refresh();
            }
            // If the dialog result is false (user clicked cancel), a cancelled message is displayed
            else 
            {
                MessageBox.Show("Cancelled!");
            }
        }

        // Handling when user clicks remove button
        private void btnRemove_Click(object sender, RoutedEventArgs e)
        {
            // Verifying that an item was selected in the list box
            if (lbItems.SelectedItem != null) 
            {
                // Asks the user if they are sure. If yes, the item is removed
                string message = "Are you sure you wish to remove this item?";
                MessageBoxButton buttons = MessageBoxButton.YesNo;
                MessageBoxImage icon = MessageBoxImage.Question;
                MessageBoxResult result = MessageBox.Show(message, "", buttons, icon);
                if (result == MessageBoxResult.Yes) 
                {
                    order.Remove((Sprocket)lbItems.SelectedItem);
                    lbItems.Items.Refresh();
                }
            }
        }

        // Handling when user clicks update button (saves a file with the order)
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            // Sets the customer name field. If not local pickup, creates an address object and sets it to the address field
            order.CustomerName = txbCustomerName.Text;
            if (cbLocalPickup.IsChecked == false)
            {
                Address address = new Address();
                address.Street = txbStreet.Text;
                address.City = txbCity.Text;
                address.State = txbState.Text;
                address.ZipCode = txbZip.Text;
                order.Address = address;
            }
            // If local pickup, address field is set to null
            else 
            {
                order.Address = null;
            }
            // Creating a save file dialog
            SaveFileDialog saveFile = new SaveFileDialog();

            // If the user clicks save, the file is written
            if (saveFile.ShowDialog() == true) 
            {
                // Streamwriter created with "using" so it will clean up on its own. 
                using (StreamWriter file = new StreamWriter(saveFile.OpenFile())) 
                {
                    // Writes the order information, then iterates through the items to write them line by line as well
                    file.WriteLine(order.ToString());
                    file.WriteLine("\nOrder Items: \n");
                    foreach (Sprocket item in order.Items) 
                    {
                        file.WriteLine(item.ToString());
                    }
                }
            }
        }
    }
}