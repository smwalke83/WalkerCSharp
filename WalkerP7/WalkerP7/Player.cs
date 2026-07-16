// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: Player.cs

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WalkerP7
{
    // Player class contains player information
    public class Player
    {
        // Tracks total size of items in inventory
        private int inventorySize;
        // Observable Collection (more compatible with WPF than list) to store user inventory
        public ObservableCollection<IPortable> Inventory { get; set; }
        // Stores user's current location
        public MapLocation Location { get; set; }
        // Maximum inventory size - Initialized to 5 since there were no instructions
        public int MaxInventory { get; set; }
        // Constructor sets the provided location and initializes starting values
        public Player(MapLocation location) 
        {
            Location = location;
            Inventory = new ObservableCollection<IPortable>();
            MaxInventory = 5;
            inventorySize = 0;
        }
        // Method to add an inventory item - if the inventory is too full, returns false. Calculates inventory size after item is added.
        public bool AddInventoryItem(IPortable item) 
        {
            if (inventorySize + item.Size > MaxInventory)
            {
                return false;
            }
            else 
            {
                Inventory.Add(item);
                calc();
                return true;
            }
        }
        // Method to remove an inventory item. Calculates inventory size after item is removed.
        public void RemoveInventoryItem(IPortable item) 
        {
            if (Inventory.Contains(item)) 
            {
                Inventory.Remove(item);
                calc();
            }
        }
        // Method to calculate inventory size.
        private void calc() 
        {
            inventorySize = 0;
            foreach (IPortable item in Inventory) 
            {
                inventorySize += item.Size;
            }
        }
    }
}
