using System;

//example 1
/*namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 10;
            var b = a;
            b++;
            Console.WriteLine(string.Format("a: {0},b:{1} ", a,b));
            //if we copy a value type to different variable, the copy
            //of that variable is copied and stored in an target variable
            //that is why we call them as "value types"

            var array1 = new int[3] { 1, 2, 3 };
            var array2 = array1;
            array2[0] = 0;
            Console.WriteLine(array2[0]);

        }
    }
}

*/

// example 2

namespace CSharpFundamentals
{
    public class Person
    {
        public int Age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            var number = 1;
            Increment(number);
            Console.WriteLine(number);// its not effected by Increment method

            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);

        }

        public static void Increment(int number)
        {
            number += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }
}
