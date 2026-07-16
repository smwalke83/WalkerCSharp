// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: GameObject.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP7
{
    // Abstract class GameObject is the parent of InventoryItem, HidingPlace, and PortableHIdingPlace
    // Class did not need to be abstract, but since it is never instantiated I made it abstract at the end to see if the program would still work
    public abstract class GameObject
    {
        // All children will have a Description property
        public string Description { get; set; }

        // Constructor that sets a default empty description and an overloaded constructor that sets the description to the parameter
        public GameObject() 
        {
            Description = "";
        }

        public GameObject(string description) 
        {
            Description = description;
        }

        // ToString override
        public override string ToString()
        {
            return Description;
        }
    }
}
