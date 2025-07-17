using System;
class Program_15
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int sum = 0, temp = num;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit * digit * digit;
            temp /= 10;
        }
        Console.WriteLine(sum == num ? "Armstrong Number" : "Not Armstrong Number");
    }
}
