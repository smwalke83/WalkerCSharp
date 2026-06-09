// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File: Program.cs
// Project: Quiz 2

using System;
using System.Collections.Generic;
namespace TShirtOrders
{
    class Program
    {
        private const string COMPANYNAME = "Super Shirt Ordermatic 3000";
        private const string COMPANYSLOGAN = "The best shirt ordering system in the multiverse!";

        static void Main(string[] args)
        {
            Header();
            char option;
            List<TShirtOrder> orders = new List<TShirtOrder>();
            do
            {
                DisplayShirtOrders(orders);
                option = GetStringFromUser("(A)dd shirt (R)emove shirt (T)otal (E)xit: ").Trim().ToUpper()[0];
                switch(option)
                {
                    case 'A':
                        AddShirtOrder(orders);
                        break;
                    case 'R':
                        RemoveShirtOrder(orders);
                        break;
                    case 'T':
                        DisplayTotal(orders);
                        break;

                }                
            } while (option!='E');
            Console.WriteLine("Thank you for using "+ COMPANYNAME);
        }
        private static void DisplayTotal(List<TShirtOrder> orders)
        {
            decimal total = 0;
            foreach (TShirtOrder order in orders)
            {
                total += order.Price;
            }
            Console.WriteLine("Total price of order is: " + total);
        }

        private static void RemoveShirtOrder(List<TShirtOrder> orders)
        {
            int index = GetIntFromUser("Enter index of shirt order to remove: ");
            if (GetBoolFromUser("Are you sure you want to delete this order"))
            {
                // This line was passing the index value into the Remove method, which wants the value of the item in the list, not the index. I also removed one from the user provided index as they are likely to provide a number starting from 1, not 0, based on the way the list is displayed to them
                orders.Remove(orders[index -1]);
            }
        }
        private static void AddShirtOrder(List<TShirtOrder> orders)
        {
            TShirtOrder order = new TShirtOrder();
            order.FirstName = GetStringFromUser("Please enter your first name: ");
            order.LastName = GetStringFromUser("Please enter your last name: ");
            order.IsLocalPickup = GetBoolFromUser("Local pickup");
            if (!order.IsLocalPickup)
            {
                order.Address = GetStringFromUser("Address: ");
            }
            order.OrderDate = DateTime.Now;
            order.PrintAreaInSqIn = GetDoubleFromUser("Please enter area of your design in square inches: ");
            order.NumColors = GetIntFromUser("Please enter number of colors: ");
            order.NumShirts = GetIntFromUser("Please enter the number of shirts: ");
            Console.WriteLine(order.ToString());
            orders.Add(order);
        }
        private static void DisplayShirtOrders(List<TShirtOrder> orders)
        {
            Console.WriteLine();
            Console.WriteLine("Current shirts orders:");
            if (orders.Count > 0)
            {
                // Orders.Count was initailly called like a method instead of a property ( orders.Count() )
                for (int i = 0; i < orders.Count; ++i)
                {
                    Console.WriteLine((i + 1) + ": " + orders[i]);
                }
            }
            else
            {
                Console.WriteLine("No shirts in order.");
            }
            Console.WriteLine();
        }
        private static void Header()
        {
            Console.WriteLine("Welcome to "+ COMPANYNAME+"!");
            Console.WriteLine(COMPANYSLOGAN);
            Console.WriteLine();
        }
        private static bool GetBoolFromUser(string prompt)
        {
            Console.Write(prompt + " (y/n)? ");
            return Console.ReadLine().ToLower()[0] == 'y';
        }
        private static int GetIntFromUser(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }
        private static double GetDoubleFromUser(string prompt)
        {
            Console.Write(prompt);
            return int.Parse(Console.ReadLine());
        }

        private static string GetStringFromUser(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }
    }
}
