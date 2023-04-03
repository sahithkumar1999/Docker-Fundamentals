using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            var number=2; // initializing byte data type
            var count = 10; // initializing integer data type
            var totalPrice = 20.95f; // initializing Float data type
            var character = 'A';  // initializing Char data type
            var firstName = "Sahith";// initializing String data type
            var isWorking = false;  // initializing bool data type
            const float Pi = 3.14f; // initializing Constant value with float data type
            Console.WriteLine(number);  // Shortcut to write "Console.WriteLine" is type cw and press tab
            Console.WriteLine(count);
            Console.WriteLine(totalPrice);
            Console.WriteLine(character);
            Console.WriteLine(firstName);
            Console.WriteLine(isWorking);
            Console.WriteLine(Pi);
            Console.WriteLine("{0} {1}", byte.MinValue,byte.MaxValue);
            Console.WriteLine("{0} {1}", float.MinValue, float.MaxValue);
        }
    }
}