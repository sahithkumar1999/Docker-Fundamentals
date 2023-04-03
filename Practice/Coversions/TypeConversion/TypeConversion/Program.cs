using System;

namespace TypeConversion
{
    class program
    {
        static void Main(string[] args)
        {
            byte b = 1;
            int i = b; // implicit type conversion
            Console.WriteLine(i);

            int b1 = 2;
            byte b2 = (byte)b1; // explicit type conversion
            Console.WriteLine(b2);

            int b3 = 1000;
            byte b4 = (byte)b3; // explicit type conversion beyond the limit
            Console.WriteLine(b4);


            //string number = "1234";
            //int b5= (int)number;  // non- compatable data types 
            //Console.WriteLine(b5);

            string number = "1234";
            int b5= Convert.ToInt32(number);  // non- compatable data types 
            Console.WriteLine(b5);

            try
            {
                string number1 = "1234";
                int b6 = Convert.ToByte(number);  // the code will crash so, we can use try
                                                  // and catch method
                Console.WriteLine(b6);
            }
            catch(Exception)
            {
                Console.WriteLine("the number could not be converted to byte");
            }
        }
    }
}