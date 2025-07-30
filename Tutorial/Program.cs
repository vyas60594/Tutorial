using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(n + " " + n + " " + n);

     
        for (int i = 1; i < n; i++)
        {
            Console.WriteLine(n + " " + i + " " + n);
        }

         Console.WriteLine(n + " " + n + " " + n);
    }
}
