// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: SprocketOrderForm.xaml.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP5
{
    // Plastic sprocket inherits from sprocket
    public class PlasticSprocket : Sprocket
    {
        // Constant for material
        private const string MATERIAL = "Plastic";

        // Constructors, one that calls the base constructor with the three fields, one calls the larger constructor with default values
        public PlasticSprocket(int itemID, int numItems, int numTeeth) : base(itemID, numItems, numTeeth)
        {
        }

        public PlasticSprocket() : this(-1, 0, 0)
        {
        }

        // Calculate override with cost for plastic
        protected override void Calculate()
        {
            Price = (decimal)(NumTeeth * NumItems * 0.02);
        }

        // To String override to show material
        public override string ToString()
        {
            return base.ToString() + " Material: " + MATERIAL;
        }
    }
}
