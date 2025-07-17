using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class while_loop
    {
        public static void Main(string[] args)
        {
            // This program converts a number to its English word representation
            // For example, 321 becomes "Three Two One"
            // It uses a while loop to extract each digit of the number
            // Initialize the number to be converted    
            int num = 321;
            string[] units = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            int temp = num;
            int[] digit = new int[10];
            int count = 0;
            while (temp > 0)
            {
                digit[count] = temp % 10;
                temp = temp / 10;
                count =count+ 1;
            }
            Console.WriteLine("The number is: " + num);
            for (int i = count - 1; i >= 0; i--)
            {
                Console.Write(units[digit[i]]);
            }  
        }
    }
}
