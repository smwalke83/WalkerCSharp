// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File Name: LogoOrderItem.cs

using System;
using System.Collections.Generic;
using System.Text;

namespace WalkerP3
{
    public class LogoOrderItem
    {
        // properties
        private bool hasLogo;
        public bool HasLogo
        {
            get { return hasLogo; }
            set { hasLogo = value; Calc(); }
        }
        private string itemType;
        public string ItemType
        {
            get { return itemType; }
            set { itemType = value; Calc(); }
        }
        private int numColors;
        public int NumColors
        {
            get { return numColors; }
            set { numColors = value; Calc(); }
        }
        private int numItems;
        public int NumItems
        {
            get { return numItems; }
            set { numItems = value; Calc(); }
        }
        private string text;
        public string Text
        {
            get { return text; }
            set { text = value; Calc(); }
        }
        public int ItemID { get; set; }
        public decimal price { get; private set; }

        // constructors
        public LogoOrderItem(bool HasLogo, string ItemType, int NumColors, int NumItems, string Text, int ID)
        {
            hasLogo = HasLogo;
            itemType = ItemType;
            numColors = NumColors;
            numItems = NumItems;
            text = Text;
            ItemID = ID;
        }

        public LogoOrderItem(bool HasLogo, string Text) : this(HasLogo, "mug", 0, 0, Text, -1)
        {
        }

        public LogoOrderItem() : this(false, "mug", 0, 0, "", -1)
        {
        }

        // Calculates price when certain values are updated
        private void Calc()
        {
            price = 0;
            switch (itemType)
            {
                case "mug":
                    price += (decimal)3.50 * numItems;
                    break;
                case "pen":
                    price += (decimal)1.00 * numItems;
                    break;
                case "usb drive":
                    price += (decimal)4.00 * numItems;
                    break;
                default:
                    Console.WriteLine("Item type must be: 'mug', 'pen', or 'usb drive'.");
                    break;
            }
            if (text.Length > 0)
            {
                price += (decimal)0.05 * numItems;
            }
            if (hasLogo)
            {
                price += (decimal)0.10 * numItems;
                price += (decimal)0.03 * numColors * numItems;
            }
        }

        // Provides a summary of the object in a string
        public string GetOrderSummary()
        {
            if (hasLogo)
            {
                return "Order Number " + ItemID + ": \r\n" + numItems + " " + itemType + "s\r\n" + numColors + " color logo" +"\r\nText: " + text + " \r\nPrice: " + price;
            }
            else
            {
                return "Order Number " + ItemID + ": \r\n" + numItems + " " + itemType + "s\r\nText: " + text + " \r\nPrice: " + price;
            }
        }
    }
}
