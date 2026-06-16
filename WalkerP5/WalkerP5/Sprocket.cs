// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: Sprocket.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP5
{
    public abstract class Sprocket
    {
        // Protected fields numItems and numTeeth, with public properties with normal getters and setters that also call calculate
        protected int numItems;
        public int NumItems 
        {
            get { return numItems; }
            set { numItems = value; Calculate(); }
        }
        protected int numTeeth;
        public int NumTeeth 
        {
            get { return numTeeth; } 
            set { numTeeth = value; Calculate(); }
        }

        // public properties (read only)
        public decimal Price { get; protected set; }
        public int ItemID { get; protected set; }
        
        // Constructors - one with field value parameters, one without that sets defaults
        public Sprocket(int itemID, int numItems, int numTeeth) 
        {
            this.ItemID = itemID;
            this.NumItems = numItems;
            this.NumTeeth = numTeeth;
        }
        
        public Sprocket(): this(-1, 0, 0)
        {
        }

        // Abstract calculate to be overridden by children
        protected abstract void Calculate();

        // To String override to show all the fields
        public override string ToString() 
        {
            return "ID: " + ItemID + " Number: " + numItems + " Teeth: " + numTeeth + " Price: $" + Price.ToString("F2");
        }
    }
}
