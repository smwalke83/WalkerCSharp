// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Custom Exceptions Demo

using CustomExceptionsDemo;

string doAnother;
do
{
    // prompts user for a social security number, attempts to assign it to ssn object, if it fails an error is displayed and the finally block runs
    try
    {
        Console.Write("Please enter a social security number: ");
        String userInput = Console.ReadLine();
        SocialSecurityNumber ssn = new SocialSecurityNumber();
        ssn.SSN = userInput;
    }/* Commenting out old catch blocks
    catch (System.FormatException ex)
    {
        Console.WriteLine("Not a number!");
    }
    catch (System.OverflowException ex) 
    {
        Console.WriteLine("Number is too large or too small!");
    }*/
    catch (Exception ex)
    {
        Console.WriteLine("Error! " + ex.Message + "\nException type: " + ex.GetType());
    }
    finally
    {
        Console.WriteLine("This section always executes!");
    }
    Console.Write("Do another (y/n:): ");
    doAnother = Console.ReadLine();
} while (doAnother == "y");