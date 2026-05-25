// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Program: Exception Demo
// Purpose: Learn about exceptions

// I decided to start trying to code the main program file without a program class and only top-level code

string doAnother;
do
{
    try
    {
        Console.Write("Please enter num1: ");
        string num1str = Console.ReadLine();
        int num1 = int.Parse(num1str);

        Console.Write("Please enter num2: ");
        string num2str = Console.ReadLine();
        int num2 = int.Parse(num2str);

        Console.WriteLine("Num1/Num2: {0}", num1 / num2);
    }
    catch (System.FormatException)
    {
        Console.WriteLine("Not a number!");
    }
    catch (System.OverflowException)
    {
        Console.WriteLine("Number is too large or too small!");
    }
    // Added a catch for a divide by zero exception
    catch (System.DivideByZeroException)
    {
        Console.WriteLine("You cannot divide by zero!");
    }
    catch (Exception exc)
    {
        Console.WriteLine("Error! " + exc.Message + "\nException type: " + exc.GetType());
    }

    finally
    {
        Console.WriteLine("This section always executes!");
    }

    Console.Write("Do another? y/n: ");
    doAnother = Console.ReadLine();
} while (doAnother == "y");
