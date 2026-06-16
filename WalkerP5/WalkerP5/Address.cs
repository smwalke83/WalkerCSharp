// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: Address.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP5
{
    // Address class to be used by SprocketOrder class
    public class Address
    {

        // Fields for city, state, street, zip code
        public string City { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        public string ZipCode { get; set; }

        // Constructors - one with each field, one that gives defaults to each field
        public Address(string city, string state, string street, string zip) 
        {
            City = city;
            State = state;
            Street = street;
            ZipCode = zip;
        }

        public Address() : this("", "", "", "") 
        {
        }
        
        // To String override to describe the address
        public override string ToString()
        {
            return Street + "\n" + City + ", " + State + ", " + ZipCode;
        }
    }
}
