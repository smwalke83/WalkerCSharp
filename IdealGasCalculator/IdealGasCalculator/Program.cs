/*
Name: Scott Walker
Email: swalker62@student.cnm.edu
File Name: IdealGasCalculator
Date: 5/23/26
*/

using System.Runtime.CompilerServices; // This was added by Visual Studio
using System.Linq; // I am using this to check for membership within an array ie: array.Contains(element)

class IdealGasCalculator
{ 
    static void Main()
    {
        // Defining variables to use later, they should be self-explanatory
        string userInput;
        double volume;
        double mass;
        double temp;
        double pressurePA;
        double weight;
        string doAnother = "y";

        /* 
        I had some confusion here; the assignment has a method requiring these two arrays to be initialized and passed into that method to be populated.
        I have to imagine there is a cleaner way to do this, but I just initialized two arrays with zero length, and then re-assigned them to arrays of the proper length in the method.
        */
        string[] gasNames = new string[0];
        double[] molecularWeights = new double[0];

        // Displaying the header with program details
        DisplayHeader();

        // Getting the data from the .csv file and populating the gasNames, molecularWeights, and line count.
        GetMolecularWeights(ref gasNames, ref molecularWeights);

        // Using the gasNames array to display 3 columns containing all the gas names
        DisplayGasNames(gasNames);

        // The do/while loop, where the user can input a gas and some values, after which the pressure is calculated and displayed to the user.
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

            // Finding the molecular weight from the user's choice
            weight = GetMolecularWeightFromName(userInput, gasNames, molecularWeights);
            
            // Prompting the user for a volume. If the response is not 'q' or a number that can be converted to double, displays error message and restarts the loop.
            Console.WriteLine("\nPlease provide a volume for the gas in cubic meters ('q' to quit): ");
            userInput = Console.ReadLine();
            if (userInput == "q")
            {
                break;
            }
            if (double.TryParse(userInput, out result))
            {
                volume = result;
            }
            else
            {
                Console.WriteLine("\nInvalid input. Volume should be a numberical value.");
                continue;
            }

            // Same as above, but for mass
            Console.WriteLine("\nPlease provide a mass for the gas in grams ('q' to quit): ");
            userInput = Console.ReadLine();
            if (userInput == "q")
            {
                break;
            }
            if (double.TryParse(userInput, out result))
            {
                mass = result;
            }
            else
            {
                Console.WriteLine("\nInvalid input. Mass should be a numberical value.");
                continue;
            }

            // Same as above, but for temperature
            Console.WriteLine("\nPlease provide a temperature in Celsius ('q' to quit): ");
            userInput = Console.ReadLine();
            if (userInput == "q")
            {
                break;
            }
            if (double.TryParse(userInput, out result))
            {
                temp = result;
            }
            else
            {
                Console.WriteLine("\nInvalid input. Temperature should be a numberical value.");
                continue;
            }

            // Calculating the pressure of the gas using the user provided values, then displaying it to the console
            pressurePA = Pressure(mass, volume, temp, weight);
            DisplayPressure(pressurePA);

            // Asking the user if they want to go again. If they don't, the loop is not restarted and the program says goodbye and ends.
            Console.WriteLine("\nWould you like to do another? Please enter 'n' for 'no', any other input for 'yes'.");
            doAnother = Console.ReadLine();
        } while (doAnother != "n");
        Console.WriteLine("\nThank you, goodbye!");

    }

    // Displays relevent program details
    private static void DisplayHeader()
    {
        Console.WriteLine("Programmer Name: Scott Walker");
        Console.WriteLine("Program Title: Ideal Gas Calculator");
        Console.WriteLine("Program Objective: Display a list of  gases and allow a user to choose one. Then, have the user proved volume, mass, and temperature of the gas. Using these values, calculate and display the pressure to the user.\n");
    }

    // Populates gasNames and molecularWeights arrays with values from the .csv.
    private static void GetMolecularWeights(ref string[] gasNames, ref double[] molecularWeights)
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

    // Takes the array of gas names and formats a string to display them in three columns.
    private static void DisplayGasNames(string[] gasNames)
    {
        string fullString = "";

        // Adds each element in a left justified block of 25 characters. Every third iteration, adds a line break to maintain 3 columns.
        for (int i = 0; i < gasNames.Length; i++)
        {
            fullString += $"{gasNames[i], -25}";
            if ((i + 1) % 3 == 0)
            {
                fullString += "\n";
            }
        }
        Console.WriteLine(fullString);
    }

    // Finds the molecular weight of a gas provided by the user by iterating through the gasNames, finding a matching index, and pulling the relevant value from molecular weights
    private static double GetMolecularWeightFromName(string gasName, string[] gasNames, double[] molecularWeights)
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

    // Calculates pressure using mass 9grams), volume (cubic meters), temp (celcius), and molecular weight.
    private static double Pressure(double mass, double vol, double temp, double molecularWeight)
    {
        double moles = NumberofMoles(mass, molecularWeight);
        const double IDEAL_GAS_CONST = 8.3145;
        double kelvin = CelciusToKelvin(temp);
        double pressure = (moles * IDEAL_GAS_CONST * kelvin) / vol;
        return pressure;
    }

    // Calculates moles using mass and molecular weight.
    private static double NumberofMoles(double mass, double molecularWeight)
    {
        double moles = mass / molecularWeight;
        return moles;
    }

    // Converts celcius to kelvin.
    private static double CelciusToKelvin(double celcius)
    {
        double kelvin = celcius + 273.15;
        return kelvin;
    }

    // Displays pressure in pascals and PSI.
    private static void DisplayPressure(double pressure)
    {
        double psi = PaToPSI(pressure);
        Console.WriteLine($"\nPressure: {pressure:F2} Pascals");
        Console.WriteLine($"Pressure: {psi:F2} PSI");
    }

    // Converts pressure from pascals to PSI.
    private static double PaToPSI(double pascals)
    {
        double psi = pascals * 0.000145038;
        return psi;
    }
}
