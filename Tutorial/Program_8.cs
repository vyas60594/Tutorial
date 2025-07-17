using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        string upperName = name.ToUpper();

        Console.WriteLine("Uppercase Name: " + upperName);

        Console.ReadLine(); // To keep the console window open
    }
}
