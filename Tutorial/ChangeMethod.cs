using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class ChangeMethod
    {
        public static void Change(int x, int y)
        {
            x = 20;
            y = 30;
            Console.WriteLine("x : " + x);
            Console.WriteLine("y : " + y);
        }
        static void Main(string[] args)
        {
            int a = 10; int b = 20;
            Console.WriteLine("a : " + a);
            Console.WriteLine("a : " + a);
            Console.WriteLine("b : " + b);
            Change(a, b);
            Console.WriteLine("a : "+a);
            Console.WriteLine("b : " + b);

        }
      


    }
}
