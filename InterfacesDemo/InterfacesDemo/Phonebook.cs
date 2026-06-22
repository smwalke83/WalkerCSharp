using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    // Phonebook class to contain a list of objects that implement IPhoneBookItem interface
    class Phonebook
    {
        public List<IPhoneBookItem> PhoneBookEntries { get; set; }

        // Constructor instantiates the list of IPhoneBookItem objects
        public Phonebook() 
        {
            PhoneBookEntries = new List<IPhoneBookItem>();
        }

        // Method to display items in phonebook, using the method required by the IPhoneBookItem interface (GetContactSummary)
        public string GetPhoneBook() 
        {
            string phonebook = "";
            foreach (var item in PhoneBookEntries) 
            {
                phonebook += item.GetContactSummary() + "\n\n";
            }
            return phonebook;
        }
    }
}
