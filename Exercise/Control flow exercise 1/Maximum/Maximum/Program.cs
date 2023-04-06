namespace Maximum
{
    class Program
    {
        static void Main(string[] args)
        {
            var number1 = 10;
            var number2 = 20;

            if (number1 > number2)
            {
                Console.WriteLine("Number1 is maximum");
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Number2 is maximum");
            }
        }
    }
}