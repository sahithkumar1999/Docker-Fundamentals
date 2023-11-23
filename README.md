# C# Basics


## Our First C# Program

```charp
class HelloCSharp
{
  static void Main(string[] args)
  {
    System.Console.WriteLine("Hello C#!");
  }
}

```
 First program consists of three logical parts:
- Definition of a class HelloCSharp;
- Definition of a method Main();
- Contents of the method Main().

### Defining a Class
On the first line of our program we define a class called HelloCSharp. The 
simplest definition of a class consists of the keyword class, followed by its 
name. In our case the name of the class is HelloCSharp. The content of the 
class is located in a block of program lines, surrounded by curly brackets: {}.

### Defining the Main() Method
On the third line we define a method with the name Main(), which is the 
starting point for our program. Every program written in C# starts from a 
Main() method with the following title (signature):
```cshape
static void Main(string[] args)
```
The method must be declared as shown above, it must be static and void, it 
must have a name Main and as a list of parameters it must have only one 
parameter of type array of string. In our example the parameter is called 
args but that is not mandatory. This parameter is not used in most cases so it 
can be omitted (it is optional). In that case the entry point of the program can 
be simplified and will look like this:
```
static void Main()
```
If any of the aforementioned requirements is not met, the program will 
compile but it will not start because the starting point is not defined correctly.

