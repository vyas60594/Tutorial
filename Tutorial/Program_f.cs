using System;

namespace ConsoleApplication1
{
    class Program_f
    {
        static void Main(string[] args)
        {
            int a, b, c, result;

            Console.Write("Enter Number 1: ");

            string str = Console.ReadLine();            // Missing statement 1

            a = Convert.ToInt32(str);

            Console.Write("Enter Number 2: ");

            str = Console.ReadLine();                   // Missing statement 2

            b = Convert.ToInt32(str);

            Console.Write("Enter Number 3: ");

            str = Console.ReadLine();

            c = Convert.ToInt32(str);                   // Missing statement 3

            result = Sum(a, b, c);

            Console.WriteLine("Sum : {0}", result);     //  Missing statement 4

            Console.Read();
        }

        static int Sum(int x, int y, int z)
        {
            int res;
            res = x + y + z;
            return res;
        }
    }
}
