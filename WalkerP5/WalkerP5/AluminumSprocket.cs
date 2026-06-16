// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: AluminumSprocket.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP5
{
    // Aluminum Sprocket class inherits from Sprocket abstract class
    public class AluminumSprocket : Sprocket
    {
        // Constant for the material, other fields are inherited
        private const string MATERIAL = "Aluminum";

        // Constructors, one with each field that calls to the base constructor, one that calls the larger constructor with default values
        public AluminumSprocket(int itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
        {
        }

        public AluminumSprocket() : this(-1, 0, 0)
        {
        }

        // Calculate override with cost for Aluminum
        protected override void Calculate()
        {
            Price = (decimal)(NumTeeth * NumItems * 0.04);
        }

        // To String override to display material
        public override string ToString()
        {
            return base.ToString() + " Material: " + MATERIAL;
        }
    }
}
