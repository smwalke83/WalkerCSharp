// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: TravelWindow.xaml.cs

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

namespace WalkerP7
{
    // This class is the UI component of the program. DisplayLocation and lbTraveOptions_MouseDoubleClick were already written and remain unchanged. I updated the constructor and wrote everything else
    public partial class TravelWindow : Window
    {
        // Map and Player objects store game data
        Map game;
        Player player;

        // Constructor for the form - initializes the form, game and player objects, and sets starting information
        public TravelWindow()
        {
            InitializeComponent();
            game = new Map();
            player = new Player(game.Locations[0]);
            txbGameStatus.Text = "Welcome to the Faire! Search/Take/Drop an inventory item or travel to a new location!";
            DisplayLocation();
        }

        // Sets values for text boxes and list boxes
        private void DisplayLocation()
        {
            txbLocationDescription.Text = player.Location.Description;
            lbTraveOptions.ItemsSource = player.Location.TravelOptions;
            lbLocationItems.ItemsSource = player.Location.Items;
            lbInventory.ItemsSource = player.Inventory;
        }

        // Handling when the user double clicks a travel option
        private void lbTraveOptions_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            // Sets new location to selected location and displays that to the user
            TravelOption to = (TravelOption)lbTraveOptions.SelectedItem;
            player.Location = to.Location;
            DisplayLocation();
            txbGameStatus.Text = "Successfully travelled to new location.";
        }
        // Handling when the user clicks the search button
        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            // If a location item isn't selected, prompts the user to do so
            if (lbLocationItems.SelectedIndex == -1) 
            {
                txbGameStatus.Text = "Please select an item that is not in your inventory to search!";
                return;
            }
            // Getting the selected object and creating a variable to store the hidden item
            GameObject obj = (GameObject) lbLocationItems.SelectedItem;
            GameObject item;
            // If the object uses the IHidingPlace interface...
            if (obj is IHidingPlace)
            {
                // Casting the object into an IHidingPlace object and calling the search method, assignig the result into the item variable
                IHidingPlace hide = (IHidingPlace)obj;
                item = hide.Search();
                // If the hidden item is not null, adds it to the location items and alerts the user
                if (item != null)
                {
                    player.Location.Items.Add(item);
                    txbGameStatus.Text = "Searched " + hide.ToString() + " and found: " + item.ToString() + "!";
                }
                // Otherwise, tells the user there was no item in the hiding place
                else
                {
                    txbGameStatus.Text = "Searched " + hide.ToString() + " but there was nothing inside...";
                }
            }
            // If the object does not use the IHidingPlace interface, alerts the user that the object is not a hiding place
            else 
            {
                txbGameStatus.Text = obj.ToString() + " is not a hiding place.";
            }
        }
        // Handling when the user clicks the take button
        private void btnTake_Click(object sender, RoutedEventArgs e)
        {
            // If there isn't a location item selected, prompts the user to select one
            if (lbLocationItems.SelectedIndex == -1)
            {
                txbGameStatus.Text = "Please select an item that is not in your inventory to take!";
                return;
            }
            // Getting the selected object
            GameObject obj = (GameObject)lbLocationItems.SelectedItem;
            // If the selected object uses the IPortable interface...
            if (obj is IPortable)
            {
                // Casting the item into the proper class and calling the player method AddInventoryItem
                IPortable portable = (IPortable)obj;
                bool takeable = player.AddInventoryItem(portable);
                // If AddInventoryItem returned true, the item was added to the inventory. The user is alerted and the item is removed from the location items list 
                if (takeable)
                {
                    txbGameStatus.Text = "Added " + portable.ToString() + " to inventory!";
                    player.Location.Items.Remove((GameObject)portable);
                }
                // If AddInventoryItem returned false, the user is alerted that their inventory is too full
                else
                {
                    txbGameStatus.Text = "Your inventory is full! Please drop an item first!";
                }
            }
            // If the selected object doesn't use the IPortable interface, the user is alerted that the item cannot be taken with them
            else 
            {
                txbGameStatus.Text = obj.ToString() + " cannot be taken with you!";
            }
        }
        // Handling the user clicking the drop button
        private void btnDrop_Click(object sender, RoutedEventArgs e)
        {
            // If an item in the inventory isn't selected, the player is prompted to select one
            if (lbInventory.SelectedIndex == -1)
            {
                txbGameStatus.Text = "Please select an item in your inventory to drop!";
                return;
            }
            // Getting the selected object
            GameObject obj = (GameObject)lbInventory.SelectedItem;
            // Casting the object to IPortable and removing it from the inventory list, then adding it to the location items list
            player.RemoveInventoryItem((IPortable)obj);
            player.Location.Items.Add(obj);
        }
    }
}