// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: PortableHidingPlace.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP7
{
    // PortableHidingPlace class inherits from GameObject and implements IPortable and IHidingPlace - requiring a Size property, a HiddenObject property, and a Search method
    public class PortableHidingPlace : GameObject, IPortable, IHidingPlace
    {
        // Stores the hidden object; nullable since once it is searched, it is set to null
        public GameObject? HiddenObject { get; set; }
        // Stores the size of the object for inventory management purposes
        public int Size { get; set; }
        // Constructor that sets the hidden object, the size, and the description (by calling the parent constructor)
        public PortableHidingPlace(GameObject hiddenObject, int size, string description) : base(description)
        {
            HiddenObject = hiddenObject;
            Size = size;
        }
        // Search method returns the hidden object, if there is one, and sets hiddneObject to null
        public GameObject Search() 
        {
            GameObject? temp = HiddenObject;
            HiddenObject = null;
            return temp;
        }
    }
}
