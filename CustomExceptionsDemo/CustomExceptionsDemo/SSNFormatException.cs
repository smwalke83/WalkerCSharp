// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Custom Exceptions Demo

using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptionsDemo
{
    // custom exception with custom message, everything else is inherited from exception class
    public class SSNFormatException : Exception
    {
        public SSNFormatException() : base("Not a valid Social Security Nubmer.") 
        {
        }
    }
}
