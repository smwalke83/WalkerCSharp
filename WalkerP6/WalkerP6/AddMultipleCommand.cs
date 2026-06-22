// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: AddMultipleCommands.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP6
{
    // Add Multiple Command class implements the IInventoryCommand interface, which requires Do and Undo methods
    public class AddMultipleCommand : IInventoryCommand
    {
        // Members - number for randomizing, Inventory Item, and Target List of inventory items
        int number;
        InventoryItem Item { get; set; }
        List<InventoryItem> TargetList { get; set; }

        // Constructor - requires target list and inventory item
        public AddMultipleCommand(List<InventoryItem> targetList, InventoryItem item) 
        {
            TargetList = targetList;
            Item = item;
        }

        // Do method - Generates a random number from 1-6, adds that many items to the list
        public void Do() 
        {
            Random random = new Random();
            number = random.Next(1, 7);
            for (int i = 0; i < number; i++) 
            {
                TargetList.Add(Item);
            }
        }

        // Undo method - Removes items from the list equal to the randomly generated number
        public void Undo() 
        {
            for (int i = 0; i < number; i++) 
            {
                TargetList.Remove(Item);
            }
        }
    }
}
