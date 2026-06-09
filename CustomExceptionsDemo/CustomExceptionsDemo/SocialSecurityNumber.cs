// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Custom Exceptions Demo

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace CustomExceptionsDemo
{
    // Class to contain a SSN or throw an error if the format is wrong
    public class SocialSecurityNumber
    {
        private string ssn;
        public string SSN 
        {
            get { return ssn; }
            set 
            {
                string pattern = @"^\d{3}-\d{2}-\d{4}$";
                if (Regex.IsMatch(value, pattern))
                {
                    ssn = value;
                }
                else 
                {
                    throw new SSNFormatException();
                }
            }
        }
    }
}
