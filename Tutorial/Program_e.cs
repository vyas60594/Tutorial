using System;
// Includes the System namespace 

namespace ConsoleApplication1
// Defines a namespace named ConsoleApplication1 to contain the class

{
    class Program_e
    // Declares a class named Program

    {
        static void Main(string[] args)
        // Entry point of the program

        {
            int n, fact = 1;
            // Declares two integer variables: 'n' for input number and 'fact' initialized to 1 for factorial result

            Console.WriteLine("Enter Number : ");
            // Prompts user to enter a number

            string str = Console.ReadLine();
            // Reads input from the user as a string and stores it in 'str'

            n = Convert.ToInt32(str);
            // Converts the string input to an integer and stores in variable 'n'

            for (int i = 1; i <= n; i++)
            // Loop from 1 to n to calculate factorial

            {
                fact = fact * i;
                // Multiplies current 'fact' with loop variable 'i' and stores the result back in 'fact'
            }

            Console.WriteLine("Factorial : {0}", fact);
            // Displays the final factorial value to the user

            Console.Read();
            // Waits for the user to press Enter to close the console window
        }
    }
}
