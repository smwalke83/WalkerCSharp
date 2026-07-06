using System;
using System.Collections.Generic;
using System.Text;

namespace MauiTest
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
