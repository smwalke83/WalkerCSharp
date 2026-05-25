// Programmer: Scott Walker
// Email: swalker62@student.cnm.edu
// Program: Collections Demo
// Purpose: Creating and manipulating lists

using System.Runtime.CompilerServices;

List<string> Names = new List<string>();

Names.Add("Linus Torvalds");
Names.Add("Donald Knuth");
Names.Add("Grace Hopper");
Names.Add("Donald Knuth");
Names.Add("Jean Bartik");
Names.TrimExcess();
Names.RemoveAt(3);
Names.Remove("Donald Knuth");

static void DisplayNames(List<string> Names)
{
    for (int i = 0; i < Names.Count; i++)
    {
        Console.WriteLine(Names[i]);
    }
    Console.WriteLine();
}

string doAnother;
do
{
    DisplayNames(Names);
    Console.Write("(A)dd, (R)emove, (S)earch: ");
    string operation = Console.ReadLine();
    switch (operation)
    {
        case "A":
            Console.Write("Name: ");
            Names.Add(Console.ReadLine());
            break;
        case "R":
            Console.Write("Index or name: ");
            string nameOrIndex = Console.ReadLine();
            int index;
            if (int.TryParse(nameOrIndex, out index))
            {
                Names.RemoveAt(index - 1);
            }
            else
            {
                Names.Remove(nameOrIndex);
            }
            break;
        case "S":
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Index is " + Names.IndexOf(name) + 1);
            break;
    }

    Console.Write("Do another (y/n)? ");
    doAnother = Console.ReadLine();
} while (doAnother == "y");
