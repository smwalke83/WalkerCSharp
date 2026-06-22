// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: InventoryItem.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP6
{
    // Class representing an inventory item - stores the item name and returns it with a ToString override
    public class InventoryItem
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
