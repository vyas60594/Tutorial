using System;
class Program_20
{
    static void Main()
    {
        int num = 1;
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= 4 - i; j++) Console.Write(" ");
            for (int k = 1; k <= i; k++) Console.Write(num++ + " ");
            Console.WriteLine();
        }
    }
}
