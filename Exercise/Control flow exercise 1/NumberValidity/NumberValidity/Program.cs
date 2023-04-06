namespace NumberValidity
{
    class Program
    {
        static void Main(string[] args)
        {
            var Number = 9;

            if (Number >= 1 && Number <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
                Console.WriteLine("Invalid");
        }

    }
}