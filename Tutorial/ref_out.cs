using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    internal class ref_out
    {
        static void Change(ref int a, ref int b)
        {
            a = 100;
            b = 200;
        }

        //Out parameter:-
        //1.must assign all the value that you assign in paarameter
        //2.out parameters do not require the variable to be initialized before being passed to the method.
        //3.out parameters are commonly used when a method needs to effectively "return" more than one value, as a method can only have one explicit return value
        
        static void Update(out int  x,out int y)
        {
             x = 100;
             y= 200;
        }
        
        static void Main()
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("Before change the value of a={0} and b={1} ",a,b);

            Change(ref a, ref b);
            Console.WriteLine("After change the value using referece variable value of a={0} and b={1}",a, b);

             Update(out int x, out int y);
            Console.WriteLine("After change the value using  Out variable value of a={0} and b={1}", x, y);

        }
    }
}
