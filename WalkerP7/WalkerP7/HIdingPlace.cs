// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: HidingPlace.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP7
{
    // HidingPlace inherits from GameObject and implements IHidingPlace (which requires a HiddenObject property and a Search method
    public class HidingPlace : GameObject, IHidingPlace
    {
        // backing field (per instructions). Nullable since, once searched, it can be set to null
        private GameObject? hiddenObject;
        // Property with getter/setter for backing field
        public GameObject? HiddenObject {
            get { return hiddenObject; } set { hiddenObject = value; } }
        // Constructor calls parent constructor
        public HidingPlace(string description) : base(description) 
        {
        }
        // Search method returns the hidden object, if there is one, and sets hiddenObject to null
        public GameObject Search() 
        {
            GameObject? temp = hiddenObject;
            hiddenObject = null;
            return temp;
        }
    }
}
