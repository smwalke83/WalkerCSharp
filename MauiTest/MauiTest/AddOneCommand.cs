using MauiTest;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MauiTest
{
    // Add One Command implements IInventoryCommand interface, which requires Do and Undo methods
    public class AddOneCommand : IInventoryCommand
    {
        // Class members - an inventory item and a target list of items
        InventoryItem Item { get; set; }
        ObservableCollection<InventoryItem> TargetList { get; set; }

        // Constructor - requires a target list and an item
        public AddOneCommand(ObservableCollection<InventoryItem> targetList, InventoryItem item)
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
