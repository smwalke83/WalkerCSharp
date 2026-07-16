// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: IHidingPlace.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP7
{
    // IHidingPlace interface requires a nullable HiddenObject and a Search method
    public interface IHidingPlace
    {
        public GameObject? HiddenObject { get; set; }

        public GameObject Search();
    }
}
