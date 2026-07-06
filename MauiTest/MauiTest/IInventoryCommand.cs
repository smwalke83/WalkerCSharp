using System;
using System.Collections.Generic;
using System.Text;

namespace MauiTest
{
    // Interface for inventory commands - classes implementing this will need Do and Undo methods with matching signatures
    interface IInventoryCommand
    {
        void Do();
        void Undo();
    }
}
