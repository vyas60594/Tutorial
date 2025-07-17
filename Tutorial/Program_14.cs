using System;
class Program_14
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string num = Console.ReadLine();
        string[] words = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        foreach (char ch in num)
        {
            Console.Write(words[ch - '0'] + " ");
        }
    }
}
