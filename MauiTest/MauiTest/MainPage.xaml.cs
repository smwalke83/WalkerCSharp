using System.Collections.ObjectModel;

namespace MauiTest
{
    public partial class MainPage : ContentPage
    {
        // Two lists as members - One is the list of inventory items, the other is the list of commands clicked
        private ObservableCollection<InventoryItem> inventoryItems;
        private List<IInventoryCommand> commands;

        public MainPage()
        {
            InitializeComponent();
            inventoryItems = new ObservableCollection<InventoryItem>();
            commands = new List<IInventoryCommand>();
            cvInventory.ItemsSource = inventoryItems;
        }

        private void onAddClicked(object? sender, EventArgs e)
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
            }
        }

        private void onMultClicked(object? sender, EventArgs e) 
        {
            // If there is no text in the input field, nothing happens
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
            }
        }

        private void onUndoClicked(object? sender, EventArgs e) 
        {
            // If no commands have been created yet, nothing happens
            if (commands.Count != 0)
            {
                // Gets the last command added to the command list, calls undo on that command (removing the item(s) from inventory), and removes the command from the list. Then refreshes the list box
                IInventoryCommand lastCommand = commands.Last();
                lastCommand.Undo();
                commands.Remove(lastCommand);
            }
        }
    }
}
