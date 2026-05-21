/* I kept going back and forth on whether to place the code in a Main method in the class definition or write the code and methods at the top level. I settled on the way the book is teaching it, as the provided video demo did it this way. Please let me know if you'd prefer I do it the other way. */

class ParametersDemo
{
    static void Main()
    {
        // Pass in a value type
        // Since the int is passed by value, the value of the int is unchanged.
        Console.WriteLine("Pass by value test:");
        int testVal1 = 1;
        Console.WriteLine("Original value: {0}", testVal1);
        Test(testVal1);
        Console.WriteLine("Returned value: {0}", testVal1);

        // Pass in a reference type
        // Since the array is passed by reference, the underlying values are changed.
        Console.WriteLine("\nPass in a reference type test:");
        int[] testArray = { 1, 1, 1 };
        Console.WriteLine("Original value: {0}", testArray[0]);
        TestArray(testArray);
        Console.WriteLine("Returned value: {0}", testArray[0]);

        // Out Parameter Test
        // Since out is being used, the variable is passed by reference (when using out, the argument does not need to be instantiated first)
        Console.WriteLine("\nOut parameter test:");
        int testVal2 = 2;
        Console.WriteLine("Original value: {0}", testVal2);
        TestOut(out testVal2);
        Console.WriteLine("Returned value: {0}", testVal2);

        // Ref Parameter Test
        // Since ref is being used, the variable is passed by reference
        Console.WriteLine("\nRef parameter test:");
        int testVal3 = 3;
        Console.WriteLine("Original value: {0}", testVal3);
        TestRef(ref testVal3);
        Console.WriteLine("Returned value: {0}", testVal3);

        // Optional parameter passed by position
        // The argument 4 was provided, so that is the output in the print statement
        Console.WriteLine("\nCalling TestOptional with a parameter");
        TestOptional(4);

        // Optional parameter passed with no parameters
        // No arguments are provided, so the default of 444 is the output
        Console.WriteLine("\nCalling TestOptional with no parameter");
        TestOptional();

        // Multiple parameters
        // All values are provided and those are the values sent to the console
        Console.WriteLine("\nTestMultiple all three set");
        TestMultiple(1, 2, 3);

        // Multiple parameters, not all set
        // The first two values are the ones povided as arguments, the third one is the default 333
        Console.WriteLine("\nTestMultiple set just first 2");
        TestMultiple(1, 2);

        // Multiple parameters with named parameter
        // The first value is set by the provided argument (aValue = 1), the second value is the default vBalue (222), the third value is provided via named parameter (cValue = 3)
        Console.WriteLine("\nTestMultiple set just first 2");
        TestMultiple(1, cValue: 3);

        // Overload test string method
        // Successfully calls the string vesion of the method
        Console.WriteLine("\nTest overloaded method with string");
        TestOverloaded("Test with string");

        // Overload test numeric method
        // Successfully calls the int/double version of the method
        Console.WriteLine("\nTest overloaded method with numbers");
        TestOverloaded(5, 5.5);

    }
    public static void Test(int aValue)
    {
        aValue = 111;
        Console.WriteLine("In Test Value is {0}", aValue);
    }
    public static void TestArray(int[] anArray)
    {
        anArray[0] = 111;
        Console.WriteLine("In Test value is {0}", anArray[0]);
    }

    public static void TestOut(out int aValue)
    {
        aValue = 222;
        Console.WriteLine("In TestOut Value is {0}", aValue);
    }

    public static void TestRef(ref int aValue)
    {
        aValue = 333;
        Console.WriteLine("In TestRef Value is {0}", aValue);
    }
    public static void TestOptional(int aValue = 444)
    {
        Console.WriteLine("In TestOptional Value is {0}", aValue);
    }

    public static void TestMultiple(int aValue, int bValue = 222, int cValue = 333)
    {
        Console.WriteLine("Inside TestMultiple - " + "Values: " + "{0}, {1}, {2}", aValue, bValue, cValue);
    }

    public static void TestOverloaded(string strParam)
    {
        Console.WriteLine("String overload called with a value of {0}", strParam);
    }

    public static void TestOverloaded(int intParam, double dblParam)
    {
        Console.WriteLine("Numeric overload called with values of {0} and {1}", intParam, dblParam);
    }

}





