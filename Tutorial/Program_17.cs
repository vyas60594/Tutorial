﻿using System;
class Program_17
{
    static void Main()
    {
        for (int i = 1; i <= 4; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(j + " ");
            Console.WriteLine();
        }
    }
}
