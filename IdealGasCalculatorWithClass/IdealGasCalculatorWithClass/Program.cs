// Programmer: Scott Walker
// Email: swalker62@cnm.edu
// Program: Ideal Gas Calculator With Class
// Purpose: Recreating the ideal gas calculator with a class containing private fields and get/set methods

using IdealGasClass; // Namespace for the ideal gas class

// Initializing arrays and some variables used later
string[] gasNames = new string[0];
double[] molecularWeights = new double[0];
double pressurePA;
string userInput;
string doAnother = "";

// Displaying header, getting gases and info from the .csv, and displaying gas names to the console
DisplayHeader();
GetMolecularWeights(ref gasNames, ref molecularWeights);
DisplayGasNames(gasNames);

do
{
    // Asking for the name of a gas from the user. The instructions say that if the gas isn't found to break from the loop, instead I am restarting the loop and prompting the user again. I did it this way because it felt cleaner while using the program, and you can simply type q to exit the loop (and the program).
    Console.WriteLine("\nPlease provide the name of a gas from the list ('q' to quit): ");
    userInput = Console.ReadLine();

    // Allows the user to quit the program at any time, you will see this after every prompt.
    if (userInput == "q")
    {
        break;
    }

    // Using a boolean and a method provided by LINQ to check if the gas is in the array. If not, displays error message and restarts the loop.
    bool exists = gasNames.Contains(userInput);
    double result;
    if (!exists)
    {
        Console.WriteLine("\nInvalid entry, please check spelling and capitalization.");
        continue;
    }

    // Initializing an IdealGas object to store the user provided data
    IdealGas gas = new IdealGas();

    // Finding the molecular weight from the user's choice, and setting it to the IdealGas field molecularWeight
    gas.SetMolecularWeight(GetMolecularWeightFromName(userInput, gasNames, molecularWeights));

    // A try/except block while the user inputs data. If user inputs cannot be parsed into doubles, or another error occors, it will be caught and dsiplayed to the user, then the loop will be restarted.
    try
    {
        // Prompting the user for a volume. User can input 'q' to quit.
        Console.WriteLine("\nPlease provide a volume for the gas in cubic meters ('q' to quit): ");
        userInput = Console.ReadLine();
        if (userInput == "q")
        {
            break;
        }
        result = double.Parse(userInput);
        gas.SetVolume(result);

        // Same as above, but for mass
        Console.WriteLine("\nPlease provide a mass for the gas in grams ('q' to quit): ");
        userInput = Console.ReadLine();
        if (userInput == "q")
        {
            break;
        }
        result = double.Parse(userInput);
        gas.SetMass(result);

        // Same as above, but for temperature
        Console.WriteLine("\nPlease provide a temperature in Celsius ('q' to quit): ");
        userInput = Console.ReadLine();
        if (userInput == "q")
        {
            break;
        }
        result = double.Parse(userInput);
        gas.SetTemp(result);
    }

    // Error messages for format exception, overflow exception, and a catchall for generic exceptions. If an error occurs, the loop is restarted
    catch (FormatException)
    {
        Console.WriteLine("\nError: Improper format. Entries must be decimal numbers.");
        continue;
    }
    catch (OverflowException)
    {
        Console.WriteLine("\nError: Number is too large or too small.");
        continue;
    }
    catch (Exception e)
    {
        Console.WriteLine("\nError: {0}", e.Message);
        continue;
    }


    // The idealgas object has been calculating the pressure as values are updated. A getter is used to obtain that value, then it is displayed to the user
    pressurePA = gas.GetPressure();
    DisplayPressure(pressurePA);

    // Asking the user if they want to go again. If they don't, the loop is not restarted and the program says goodbye and ends.
    Console.WriteLine("\nWould you like to do another? Please enter 'n' for 'no', any other input for 'yes'.");
    doAnother = Console.ReadLine();
} while (doAnother != "n");
Console.WriteLine("\nThank you, goodbye!");

// The methods below are unchanged from the original program, but I left the internal comments.
static void DisplayHeader()
{
    Console.WriteLine("Programmer Name: Scott Walker");
    Console.WriteLine("Program Title: Ideal Gas Calculator");
    Console.WriteLine("Program Objective: Display a list of  gases and allow a user to choose one. Then, have the user proved volume, mass, and temperature of the gas. Using these values, calculate and display the pressure to the user.\n");
}

static void GetMolecularWeights(ref string[] gasNames, ref double[] molecularWeights)
{
    // Initializing variables for StreamReader
    int count = 0;
    string path = "MolecularWeightsGasesAndVapors.csv";
    string contents = "";

    // I used the StreamReader code provided by the book and altered it slightly to record line count and save the contents in a string. 
    StreamReader reader = new StreamReader(path);
    string line = reader.ReadLine();
    while (line != null)
    {
        if (line.Trim() != "")
        {
            if (contents.Length > 0)
            {
                contents = contents + "\n" + line;
            }
            else
            {
                contents = contents + line;
            }
            count++;
        }
        line = reader.ReadLine();
    }
    reader.Close();

    // Reassigning gasNames and molecularWeights to arrays of the proper length (count-1 because I will exclude the header)
    gasNames = new string[count - 1];
    molecularWeights = new double[count - 1];

    // Creating an array containing the contents of each line in the .csv file.
    string[] contentArr = contents.Split("\n");

    // Populating the gasName and molecularWeight arrays with each value, excluding first line that just has headers
    for (int i = 1; i < contentArr.Length; i++)
    {
        string[] values = contentArr[i].Split(",");
        gasNames[i - 1] = values[0];
        molecularWeights[i - 1] = double.Parse(values[1]);
    }
}
static void DisplayGasNames(string[] gasNames)
{
    string fullString = "";

    // Adds each element in a left justified block of 25 characters. Every third iteration, adds a line break to maintain 3 columns.
    for (int i = 0; i < gasNames.Length; i++)
    {
        fullString += $"{gasNames[i],-25}";
        if ((i + 1) % 3 == 0)
        {
            fullString += "\n";
        }
    }
    Console.WriteLine(fullString);
}

static double GetMolecularWeightFromName(string gasName, string[] gasNames, double[] molecularWeights)
{
    int index = 0;
    double weight = 0;
    for (int i = 0; i < gasNames.Length; i++)
    {
        if (gasNames[i] == gasName)
        {
            index = i;
            break;
        }
    }
    weight = molecularWeights[index];
    return weight;
}

static void DisplayPressure(double pressure)
{
    double psi = pressure * 0.000145038;
    Console.WriteLine($"\nPressure: {pressure:F2} Pascals");
    Console.WriteLine($"Pressure: {psi:F2} PSI");
}