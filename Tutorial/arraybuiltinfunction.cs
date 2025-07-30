using System;
using System.Linq;

namespace Tutorial
{
    internal class arraybuiltinfunction
    {
        public static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };

            int max = a[0];
            int min = a[0];

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
                if (a[i] < min)
                {
                    min = a[i];
                }
            }

            Console.WriteLine("Original Array: " + string.Join(", ", a));
            Console.WriteLine("Array Length: " + a.Length);
            Console.WriteLine("Max number: " + a.Max());
            Console.WriteLine("Min number: " + a.Min());
            Console.WriteLine("Sum of array: " + a.Sum());
            Console.WriteLine("Average of array: " + a.Average());
           

            Array.Sort(a);
            Console.WriteLine("Sorted Array: " + string.Join(", ", a));

            Array.Reverse(a);
            Console.WriteLine("Reversed Array: " + string.Join(", ", a));

        }
    }
}
