using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    // Interface with a single method; Classes using this interface must implement a method with this signature
    interface IPhoneBookItem
    {
        string GetContactSummary();
    }
}
