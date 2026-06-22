// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: MainWindow.xaml.cs

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

namespace WalkerP6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    // MainWindow for the program, inherits from Window
    public partial class MainWindow : Window
    {
        // Two lists as members - One is the list of inventory items, the other is the list of commands clicked
        List<InventoryItem> inventoryItems;
        List<IInventoryCommand> commands;
        
        // Constructor initializes the window, the inventory items list, and the commands list
        public MainWindow()
        {
            InitializeComponent();
            inventoryItems = new List<InventoryItem>();
            commands = new List<IInventoryCommand>();
            lbxInventoryList.ItemsSource = inventoryItems;
        }

        // When the Add One Item button is clicked, this method is called
        private void btnAddOne_Click(object sender, RoutedEventArgs e)
        {
            // If there is no text in the input field, nothing happens
            if (txbItemName.Text.Length > 0)  
            {   
                // Saves the name in the text box, creates an inventory item with said name, then creates an Add One command object with the item and the inventory list
                string name = txbItemName.Text;
                InventoryItem item = new InventoryItem();
                item.Name = name;
                AddOneCommand oneCommand = new AddOneCommand(inventoryItems, item);

                // Calls the Do function with the command object, adding the item to the inventory list. Then adds the command to the commands list and refreshes the list box
                oneCommand.Do();
                commands.Add(oneCommand);
                lbxInventoryList.Items.Refresh();
            }
        }

        // When the Add Random Number button is clicked, this method is called
        private void btnAddMultiple_Click(object sender, RoutedEventArgs e)
        {
            // If ther is no text in the input field, nothing happens
            if (txbItemName.Text.Length > 0) 
            {
                // Saves the name in the text box, creates an inventory item with said name, then creates an Add Multiple command object with the item and the inventory list
                string name = txbItemName.Text;
                InventoryItem item = new InventoryItem();
                item.Name = name;
                AddMultipleCommand multCommand = new AddMultipleCommand(inventoryItems, item);

                // Calls the Do function with the command object, adding the randomized number of items to the inventory list. Then adds the command to the commands list and refreshes the list box
                multCommand.Do();
                commands.Add(multCommand);
                lbxInventoryList.Items.Refresh();
            }
        }

        // When the Undo button is clicked, this method is called
        private void btnUndo_Click(object sender, RoutedEventArgs e)
        {
            // If no commands have been created yet, nothing happens
            if (commands.Count != 0) 
            {
                // Gets the last command added to the command list, calls undo on that command (removing the item(s) from inventory), and removes the command from the list. Then refreshes the list box
                IInventoryCommand lastCommand = commands.Last();
                lastCommand.Undo();
                commands.Remove(lastCommand);
                lbxInventoryList.Items.Refresh();
            }
        }
    }
}