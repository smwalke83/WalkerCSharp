// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: IPortable.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP7
{
    // IPortable interface requires a size property
    public interface IPortable
    {
        public int Size { get; set; }
    }
}
