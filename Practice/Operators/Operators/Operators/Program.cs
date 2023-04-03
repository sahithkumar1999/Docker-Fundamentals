using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = 3;

            Console.WriteLine(a+b);
            Console.WriteLine((float)a/(float)b);

            var a1 = 1;
            var b1 = 2;
            var c1 = 3;
            Console.WriteLine(a1+b1*c1); // BODMAS rule will be valid here
            Console.WriteLine((a1 + b1) * c1);

            // comparision operators
            Console.WriteLine(a1>b1);
            Console.WriteLine(a1==c1);
            Console.WriteLine(a1!=b1);
            Console.WriteLine(!(a1!=b1));
            // logical operator
            Console.WriteLine(c1>b1 && c1>a1);
            Console.WriteLine(c1 > b1 && c1 == a1);
            Console.WriteLine(c1 > b1 || c1 == a1);
            Console.WriteLine(!(c1 > b1 || c1 == a1));


        }
    }
}