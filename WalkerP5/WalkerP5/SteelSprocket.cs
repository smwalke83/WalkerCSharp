// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: SteelSprocket.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP5
{
    // Steel sprocket class inherits from sprocket
    public class SteelSprocket : Sprocket
    {
        // Constant for the material
        public const string MATERIAL = "Steel";
        
        // Constructors, one calls the base constructor with the relevant fields, the other calls the first with default values
        public SteelSprocket(int itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
        {
        }
        
        public SteelSprocket() : this(-1, 0, 0)
        {
        }

        // Calculate override with the appropriate material cost
        protected override void Calculate()
        {
            Price = (decimal) (NumTeeth * NumItems * 0.05);
        }
        
        // To string override with the material
        public override string ToString()
        {
            return base.ToString() + " Material: " + MATERIAL;
        }
    }
}
