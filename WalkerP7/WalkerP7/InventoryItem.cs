// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: InventoryItem.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP7
{
    // InventoryItem inherits from GameObject and implements the IPortable interface, which requires a size property
    public class InventoryItem : GameObject, IPortable
    {
        // Required size field
        public int Size { get; set; }
        // Constructor sets size and calls parent constructor
        public InventoryItem(int size, string description) : base(description)
        {
            Size = size;
        }
    }
}
