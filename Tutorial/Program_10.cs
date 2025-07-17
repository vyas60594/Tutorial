using System;

class Program_10
{
    static void Main()
    {
        Console.Write("Enter your mobile number: ");
        string mobile = Console.ReadLine();

        if (mobile.Length < 5)
        {
            Console.WriteLine("Invalid input. Mobile number must be at least 5 digits.");
        }
        else
        {
            string masked = mobile.Substring(0, mobile.Length - 5) + "XXXXX";
            Console.WriteLine("Masked Mobile Number: " + masked);
        }

        Console.ReadLine(); // To keep console window open
    }
}
