// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: IInventgoryCommand.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP6
{
    // Interface for inventory commands - classes implementing this will need Do and Undo methods with matching signatures
    interface IInventoryCommand
    {
        void Do();
        void Undo();
    }
}
