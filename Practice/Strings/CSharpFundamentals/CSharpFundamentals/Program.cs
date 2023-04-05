
namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Sahith Kumar";
            var lastName = "Singari";

            var fullName = firstName + " " + lastName; // concatination

            // concatination using string.format
            var myFullName = string.Format("My name is {0} {1}", firstName, lastName);

            var names = new string[3] { "John", "Jack", "Mary" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            var text = "Hi John \n Look into the following paths \n c:\\folder1\\folder2\n c:\\folder3\\folder4";
            Console.WriteLine(text);

            // we can use an verbatim string for the above case 
            var text1 = @"Hi John
                Look into the following paths 
                c:\folder1\folder2 
                c:\folder3\folder4";
            Console.WriteLine(text1);
        }
    }
}