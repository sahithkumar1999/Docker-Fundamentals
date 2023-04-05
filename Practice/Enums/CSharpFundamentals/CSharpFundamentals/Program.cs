

namespace CSharpFundamentals
{
    public enum ShippingMethod
    {
        RegularAirMail =1,
        RegisteredAirMail=2,
        Express=3
    }

    class Program
    {
        static void Main(string[] args)
        {
            var method = ShippingMethod.Express;
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            // converting to an string
            Console.WriteLine(method.ToString());

            // converting a string to enum

            var methodName = "Express";
            var ShippingMethod1=Enum.Parse(typeof(ShippingMethod), methodName);
        }
    }
}