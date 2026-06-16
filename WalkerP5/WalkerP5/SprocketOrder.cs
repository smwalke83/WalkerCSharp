// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: SprocketOrder.cs

using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Security.RightsManagement;
using System.Text;

namespace WalkerP5
{
    // Sprocket order class to contain a list of sprockets ordered and other details
    public class SprocketOrder
    {
        // A list of sprocket items contained in the order, address of the customer and their name, and the total price
        private List<Sprocket> items;
        public List<Sprocket> Items
        {
            get { return items; }
            set { items = value; }
        }
        public Address Address { get; set; }
        public string CustomerName { get; set; }
        public decimal TotalPrice { get; set; }

        // Constructors - One with each field provided and another that sets default values
        public SprocketOrder(List<Sprocket> items, Address address, string customerName, decimal totalPrice) 
        {
            Items = items;
            Address = address;
            CustomerName = customerName;
            TotalPrice = totalPrice;
        }

        public SprocketOrder() : this(new List<Sprocket>(), new Address(), "", 0M)
        {
        }

        // Methods to add or remove items from the item list. When an item is added or removed the price is recalculated
        public void Add(Sprocket item) 
        {
            Items.Add(item);
            Calculate();
        }

        public void Remove(Sprocket item) 
        {
            Items.Remove(item);
            Calculate();
        }

        // To String override to show details. If the user selected local pickup the address is omitted
        public override string ToString()
        {
            if (Address is null)
            {
                return "Customer Name: " + CustomerName + " Item Count: " + Items.Count + " Total Price: $" + TotalPrice + "\n\nShip To:\nLocal Pickup";
            }
            else 
            {
                return "Customer Name: " + CustomerName + " Item Count: " + Items.Count + " Total Price: $" + TotalPrice + "\n\nShip To:\n" + Address.ToString();
            }
            
        }

        // Calculate method to calculate total price. Adds price from each item in the list.
        private void Calculate() 
        {
            TotalPrice = 0;
            foreach (Sprocket item in Items) 
            {
                TotalPrice += item.Price;
            }
        }
    }
}
