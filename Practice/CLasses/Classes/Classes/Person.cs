namespace Classes
{
    // Creating an Class
    public class Person
    {
        public string FirstName;
        public string LastName;

        // Declaring an method
        public void Introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}