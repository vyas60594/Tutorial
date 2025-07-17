using System;
class Program_21
{
    static void Main()
    {
        Console.Write("Enter number of terms: ");
        int terms = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter digit to repeat: ");
        int digit = Convert.ToInt32(Console.ReadLine());
        int num = 0, sum = 0;

        Console.Write("Series: ");
        for (int i = 1; i <= terms; i++)
        {
            num = num * 10 + digit;
            Console.Write(num);
            if (i < terms) Console.Write(" + ");
            sum += num;
        }
        Console.WriteLine("\nThe Sum is: " + sum);
    }
}

