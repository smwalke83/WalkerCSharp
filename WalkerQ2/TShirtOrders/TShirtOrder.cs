// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: TShirtOrder.cs
// Project: Quiz 2

using System;
namespace TShirtOrders
{
    public class TShirtOrder
    {
        // The TShirtOrder constructor didn't provide a default value for "printAreaInSqIn". Non-optional parameters need to be declared first, however providing a default value seemed safer.
        public TShirtOrder(string firstName="",string lastName = "", string address = "", DateTime? orderDate=null,bool isLocalPickup=true, double printAreaInSqIn=0.0, int numColors=1,int numShirts=1)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            OrderDate = orderDate;
            IsLocalPickup = isLocalPickup;
            this.printAreaInSqIn = printAreaInSqIn;
            this.numColors = numColors;
            this.numShirts = numShirts;
            Calc();
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime? OrderDate { get; set; }
        public bool IsLocalPickup { get; set; }
        private double printAreaInSqIn;
        public double PrintAreaInSqIn
        {
            get { return printAreaInSqIn; }
            set { printAreaInSqIn = value; Calc(); }
        }

        private int numColors;
        // The getter and setter for NumColors were returning and setting NumColors instead of the private numColors, leading to a recursive loop and stack overflow
        public int NumColors
        {
            get { return numColors; }
            set { numColors = value; Calc(); }
        }

        private int numShirts;
        public int NumShirts
        {
            get { return numShirts; }
            set { numShirts = value; Calc(); }
        }
        // The Price property initially had a private get, making it write only. The getter is now public. I set it to read-only (private get) as the calculations happen under the hood
        public decimal Price { get; private set; }
        private void Calc()
        {
            // Price is a decimal and the calculation was returning a double. It is now being cast into a decimal. There is technically a risk of the double being too large to cast to a decimal, so I added a Try/Catch block
            try
            {
                Price = (decimal)(numShirts * (numColors * 2.25 + printAreaInSqIn * .05));
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
        public override string ToString()
        {
            // OrderDate.ToString was generating an error because the nullable DateTime class has no overloaded ToString methods. I saw a couple solutions online but the simplest seems to be adding a ? after OrderDate, making the ToString output nullable
            return FirstName+" "
                +LastName+" "
                +OrderDate?.ToString("MM/dd/yyyy HH:mm:ss")+" "
                +" Price: "+Price.ToString("c");
        }
    }
}
