// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// File Name: WalkerQ1

using System.Linq.Expressions;
using WalkerQ1;

string doAnother = "y";
do
{
    
    // Instantiating gforce object and getting user input values in a try/catch block. Exceptions are reported and the loop is restarted.
    ForceCalc gForce = new ForceCalc();
    try
    {
        gForce.Object1 = GetInput("Please enter the name of the first object: ");
        gForce.Object1Mass = double.Parse(GetInput("Please enter the mass of " + gForce.Object1 + " in kilograms: "));
        gForce.Object2 = GetInput("Please enter the name of the second object: ");
        gForce.Object2Mass = double.Parse(GetInput("Please enter the mass of " + gForce.Object2 + " in kilograms: "));
        gForce.Radius = (double.Parse(GetInput("Please enter the distance between the two objects in meters: "))) / 2;
    }
    catch (FormatException)
    {
        Console.WriteLine("Format error: Please enter a number.");
        Console.WriteLine("Please try again.");
        continue;
    }
    catch (Exception e) 
    {
        Console.WriteLine("Error: " + e.Message);
        Console.WriteLine("Please try again.");
        continue;
    }

    // reporting results to the user and asking if they want to go again
    Console.WriteLine(gForce.ToString());
    Console.Write("Would you like to do another? y/n ");
    doAnother = Console.ReadLine();
} while (doAnother == "y");

// method to get user input return the value
static string GetInput(string prompt)
{
    Console.Write(prompt);
    return Console.ReadLine();
}