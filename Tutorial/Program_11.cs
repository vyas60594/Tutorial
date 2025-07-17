using System;
class Program_11
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();
        Console.Write("Enter gender (M/F): ");
        char gender = Convert.ToChar(Console.ReadLine().ToUpper());

        if (gender == 'M')
            Console.WriteLine("Mr. " + name);
        else if (gender == 'F')
            Console.WriteLine("Ms. " + name);
        else
            Console.WriteLine("Invalid gender.");
    }
}
