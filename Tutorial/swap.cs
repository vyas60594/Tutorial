using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class swap
    {
        static void Swap(ref int a , ref int b)
        {
            //int temp = a;
            //a = b;
            //b = temp;

            a = a + b;
            b = a - b;
            a = a - b;


        }
        static void Main()
        {
             int a=10; int b=20;
            Console.WriteLine("value of a is " + a+ " value of b is "+ b);

            Swap(ref a, ref b);
            Console.WriteLine("after swap value of a is "+ a+ " value of b is "+ b);



        }
    }
}
