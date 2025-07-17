using System;

class Program_9
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        string toggleName = "";

        foreach (char ch in name)
        {
            if (char.IsUpper(ch))
                toggleName += char.ToLower(ch);
            else if (char.IsLower(ch))
                toggleName += char.ToUpper(ch);
            else
                toggleName += ch; // Keep spaces or other characters as is
        }

        Console.WriteLine("Toggle Case Name: " + toggleName);

        Console.ReadLine(); // To keep console open
    }
}
