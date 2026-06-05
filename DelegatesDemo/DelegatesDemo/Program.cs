// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Project: Delegates demonstration

public class MainProgram 
{
    // Defining the delegate
    delegate void DispStrDelegate(string param);

    // Capitalize and lowercase methods
    static void Capitalize(string text)
    {
        Console.WriteLine("Your input capitalized --> " + text.ToUpper());
    }

    static void LowerCased(string text)
    {
        Console.WriteLine("Your input lower cased --> " + text.ToLower());
    }

    // Method with delegate parameter
    static void RunMyDelegate(DispStrDelegate del, string textParam) 
    {
        del(textParam);
    }

    // main method
    static void Main(string[] args) 
    {

        // get user input
        Console.Write("Please enter some text: ");
        String text = Console.ReadLine();

        // instantiating delegate objects
        DispStrDelegate saying1 = new DispStrDelegate(Capitalize);
        DispStrDelegate saying2 = new DispStrDelegate(LowerCased);
        DispStrDelegate saying3 = new DispStrDelegate(Console.WriteLine);

        // calling each delegate with input text
        saying1(text);
        saying2(text);
        saying3(text);

        // getting user input again
        Console.Write("Please enter some text: ");
        text = Console.ReadLine();

        // instantiating a multi cast delegate
        DispStrDelegate sayings = new DispStrDelegate(Capitalize);
        sayings += new DispStrDelegate(LowerCased);
        sayings += new DispStrDelegate(Console.WriteLine);

        // running the multi cast
        Console.WriteLine("Running multi cast directly: ");
        sayings(text);

        // same as above, but passing it to a method instewad of calling it
        Console.WriteLine("Running by passing delegate to another method: ");
        RunMyDelegate(sayings, text);

        // writing a lambda expression instead of delcared delegate in the method call
        Console.WriteLine("Running by passing in a lambda expression: ");
        RunMyDelegate((string t) => { Console.WriteLine("Lambda: " + t); }, text);

        // doing the same as above, removing optional syntax
        Console.WriteLine("Lambda without type: ");
        RunMyDelegate((t) => { Console.WriteLine("Lambda: " + t); }, text);

        Console.WriteLine("Lambda without parenthesis: ");
        RunMyDelegate(t => { Console.WriteLine("Lambda: " + t); }, text);

        // adding a lambda expression to a multi cast delegate
        sayings += t => { Console.WriteLine("Lambda3: " + t); };
        Console.WriteLine("Three Delegates and a lambda: ");
        RunMyDelegate(sayings, text);
    }
}









