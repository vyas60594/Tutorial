using System;
class Program_13
{
    static void Main()
    {
        int a = 0, b = 1, c;
        Console.Write(a + " " + b + " ");
        for (int i = 2; i < 11; i++)
        {
            c = a + b;
            Console.Write(c + " ");
            a = b;
            b = c;
        }
    }
}
