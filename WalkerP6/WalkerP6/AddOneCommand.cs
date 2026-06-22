// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: AddOneCommand.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP6
{
    // Add One Command implements IInventoryCommand interface, which requires Do and Undo methods
    public class AddOneCommand : IInventoryCommand
    {
        // Class members - an inventory item and a target list of items
        InventoryItem Item { get; set; }
        List<InventoryItem> TargetList { get; set; }
        
        // Constructor - requires a target list and an item
        public AddOneCommand(List<InventoryItem> targetList, InventoryItem item) 
        {
            TargetList = targetList;
            Item = item;
        }

        // Do method - adds the item to the target list
        public void Do() 
        {
            TargetList.Add(Item);
        }

        // Undo method - removes the item from the target list
        public void Undo() 
        {
            TargetList.Remove(Item);
        }
    }
}
