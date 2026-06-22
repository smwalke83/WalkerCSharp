using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    // Department class using the IPhoneBookItem interface
    class Department : IPhoneBookItem
    {
        // Department members
        public string Name { get; set; }
        public Employee Manager { get; set; }
        public string Description { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string WebSite { get; set; }

        // Constructor with default values
        public Department(string name, Employee manager = null, string description = "TBD", string phone = "TBD", string email = "TBD", string website = "TBD") 
        {
            Name = name;
            Manager = manager;
            Description = description;
            Phone = phone;
            Email = email;
            WebSite = website;
        }

        // Implementing the method from IPhoneBookItem interface
        public string GetContactSummary() 
        {
            return "Department: " + Name + "\n" + Description + "\nPhone: " + Phone + "\nEmail: " + Email + "\nWeb site: " + WebSite;
        }

    }
}
