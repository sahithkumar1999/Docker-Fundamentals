# C# Basics

# Table of Contents

- [Our First C# Program](#section-1)
## 1. Our First C# Program

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

### 1.1 Defining a Class
On the first line of our program we define a class called HelloCSharp. The 
simplest definition of a class consists of the keyword class, followed by its 
name. In our case the name of the class is HelloCSharp. The content of the 
class is located in a block of program lines, surrounded by curly brackets: {}.

### 1.2 Defining the Main() Method
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

[Click here for more Keywords](https://github.com/sahithkumar1999/Learning_Courses/blob/C%23_Basics/Notes/KeyWords.md)

## 2. The Program Code Must Be Correctly Formatted
Formatting is adding characters such as spaces, tabs and new lines, which are 
insignificant to the compiler and they give the code a logical structure and 
make it easier to read. Let’s for example take a look at our first program 
(the short version of the Main() method):
```
class HelloCSharp
{
  static void Main()
  {
    System.Console.WriteLine("Hello C#!");
  }
}
```
The program contains seven lines of code and some of them are indented 
more than others. All of that can be written without tabs as well, like so:
```
class HelloCSharp
{
static void Main()
{
System.Console.WriteLine("Hello C#!");
}
}
```
Or on the same line:
```
class HelloCSharp{static void Main(){System.Console.WriteLine( 
"Hello C#!");}}
```
Or even like this:
```
 class
 HelloCSharp
{
 static void Main()
 { System .
Console.WriteLine("Hello C#!") ;} }
```
The examples above will compile and run exactly like the formatted code but 
they are more difficult to read and understand, and therefore difficult to 
modify and maintain.

## 3. KeyWords
![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/e653a6d5-661e-4cfb-ade0-61fac21e3b06)
![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/7146f407-54a3-4ab8-8189-dea8dd71f9a6)

## 4. The .NET Platform
The .NET platform contains the C# language, CLR and many auxiliary 
instruments and libraries ready for use. There are a few versions of .NET 
according to the targeted user group:
- .NET Framework is the most common version of the .NET environment 
because of its general purpose. It is used in the development of console 
applications, Windows applications with a graphical user interface, web 
applications and many more.
- .NET Compact Framework (CF) is a "light" version of the standard 
.NET Framework and is used in the development of applications for 
mobile phones and other PDA devices using Windows Mobile Edition.
- Silverlight is also a "light" version of the .NET Framework, intended to 
be executed on web browsers in order to implement multimedia and 
Rich Internet Applications.
- .NET for Windows Store apps is a subset of .NET Framework 
designed for development and execution of .NET applications in 
Windows 8 and Windows RT environment (the so called Windows 
Store Apps).
### 4.1 .NET Framework
The standard version of the .NET platform is intended for development and 
use of console applications, desktop applications, Web applications, Web 
services, Rich Internet Applications, mobile applications for tablets and smart 
phones and many more. Almost all .NET developers use the standard version.

## 5. Data Types
- Integer types – sbyte, byte, short, ushort, int, uint, long, ulong;
- Real floating-point types – float, double;
- Real type with decimal precision – decimal;
- Boolean type – bool;
- Character type – char;
- String – string;
- Object type – object.


![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/ab8cb6c9-0f2b-4171-a502-c9da55785342)

### 5.1 Integer Types
Integer types represent integer numbers and are sbyte, byte, short, 
ushort, int, uint, long and ulong. Let’s examine them one by one.
- The sbyte type is an 8-bit signed integer. This means that the number of 
possible values for it is 2^8
, i.e. 256 values altogether, and they can be both, 
positive and negative. The minimum value that can be stored in sbyte is 
SByte.MinValue = -128 (-2
7
), and the maximum value is SByte.MaxValue = 
127 (27
-1). The default value is the number 0
Formula : -2^n to (2^n - 1)
```
double result = Math.Pow(2, n);
Console.WriteLine($"2^{n} = {result}");
```

```
SByte MinValue = SByte.MinValue;
SByte MaxVal = SByte.MaxValue;
Console.WriteLine(MinValue);
Console.WriteLine(MaxVal);
```
- The int type is the most often used type in programming. Usually 
programmers use int when they work with integers because this type is 
natural for the 32-bit microprocessor and is sufficiently "big" for most of the 
calculations performed in everyday life
- The uint type is 32-bit unsigned integer type. Its default value is the 
number 0u or 0U (the two are equivalent). The 'u' letter indicates that the 
number is of type uint (otherwise it is understood as int). The minimum value that it can take is UInt32.MinValue = 0, and the maximum value is 
UInt32.MaxValue = 4,294,967,295 (2^32-1).
- The long type is a 64-bit signed type with a default value of 0l or 0L (the 
two are equivalent but it is preferable to use 'L' because the letter 'l' is easily 
mistaken for the digit one '1'). The 'L' letter indicates that the number is of 
type long (otherwise it is understood int). The minimal value that can be 
stored in the long type is
```
Int64.MinValue = -9,223,372,036,854,775,808
(-2^63) and its maximum value is
Int64.MaxValue = 9,223,372,036,854,
775,807  (2^63-1).
```
- The biggest integer type is the ulong type. It is a 64-bit unsigned type, 
which has as a default value – the number 0u, or 0U (the two are equivalent). 
The suffix 'u' indicates that the number is of type ulong (otherwise it is 
understood as long). The minimum value that can be recorded in the ulong
type is
```
UInt64.MinValue = 0 and the maximum is UInt64.MaxValue = 
18,446,744,073,709,551,615 (2^64-1).
```
## 5.1.1 Integer Types – Example
```
// Declare some variables
byte centuries = 20;
ushort years = 2000;
uint days = 730480;
ulong hours = 17531520;
// Print the result on the console
Console.WriteLine(centuries + " centuries are " + years +
" years, or " + days + " days, or " + hours + " hours.");
// Console output:
// 20 centuries are 2000 years, or 730480 days, or 17531520
// hours.
ulong maxIntValue = UInt64.MaxValue;
Console.WriteLine(maxIntValue); // 18446744073709551615
```

## 5.2 Real Floating-Point Types

### 5.2.1 Real Type Floa
The first type we will consider is the 32-bit real floating-point type **float**. It 
is also known as a single precision real number. Its default value is 0.0f
or 0.0F (both are equivalent). The character 'f' when put at the end explicitly 
indicates that the number is of type float.  range from $±1.5 × 10^-45 to ±3.4 × 10^38$

## 5.2.2 Real Type Double
The second real floating-point type in the C# language is the double type. 
It is also called double precision real number and is a 64-bit type with a 
default value of 0.0d and 0.0D (the suffix 'd' is not mandatory because by 
default all real numbers in C# are of type double). This type has precision of 
15 to 16 decimal digits. The range of values, which can be recorded in double
(rounded with precision of 15-16 significant decimal digits), is from
$±5.0 × 10^{-324} to ±1.7 × 10^{308}$.

The smallest real value of type double is the constant Double.MinValue = 
-1.79769e+308 and the largest is Double.MaxValue = 1.79769e+308. The 
closest to 0 positive number of type double is Double.Epsilon = 4.94066e324. As with the type float the variables of type double can take the special values: Double.PositiveInfinity (+∞), Double.NegativeInfinity (-∞) 
and Double.NaN (invalid number).

### 5.2.3 Real Floating-Point Types – Example
```
float floatPI = 3.14f;
Console.WriteLine(floatPI); // 3.14
double doublePI = 3.14;
Console.WriteLine(doublePI); // 3.14
double nan = Double.NaN;
Console.WriteLine(nan); // NaN
double infinity = Double.PositiveInfinity;
Console.WriteLine(infinity); // Infinity
```
### 5.2.3 Real Double-Point Types – Example
```
// Declare some variables
float floatPI = 3.141592653589793238f;
double doublePI = 3.141592653589793238;
// Print the results on the console
Console.WriteLine("Float PI is: " + floatPI);
Console.WriteLine("Double PI is: " + doublePI);
// Console output:
// Float PI is: 3.141593
// Double PI is: 3.14159265358979
```
## 5.3 Boolean Type
Boolean type is declared with the keyword bool. It has two possible values: 
true and false. Its default value is false. It is used most often to store the 
calculation result of logical expressions.
```
// Declare some variables
int a = 1;
int b = 2;
// Which one is greater?
bool greaterAB = (a > b);
// Is 'a' equal to 1?
bool equalA1 = (a == 1);
// Print the results on the console
if (greaterAB)
  {
    Console.WriteLine("A > B");
  }
else
  {
    Console.WriteLine("A <= B");
  }
Console.WriteLine("greaterAB = " + greaterAB);
Console.WriteLine("equalA1 = " + equalA1);
```
## 5.4 Character Type
Character type is a **single character** (16-bit number of a Unicode table 
character). It is declared in C# with the keyword char. The Unicode table is 
a technological standard that represents any character (letter, punctuation, 
etc.) from all human languages as writing systems (all languages and 
alphabets) with an integer or a sequence of integers. More about the Unicode
table can be found in the chapter "Strings and Text Processing". The smallest 
possible value of a char variable is 0, and the largest one is 65535. The 
values of type char are letters or other characters, and are enclosed in 
apostrophes
### 5.4.1 Character Type – Example
```
// Declare a variable
char ch = 'a';
// Print the results on the console
Console.WriteLine(
"The code of '" + ch + "' is: " + (int)ch);
ch = 'b';
Console.WriteLine(
"The code of '" + ch + "' is: " + (int)ch);
ch = 'A';
Console.WriteLine(
"The code of '" + ch + "' is: " + (int)ch);
// Console output:
// The code of 'a' is: 97
// The code of 'b' is: 98
// The code of 'A' is: 65
```
![image](https://github.com/sahithkumar1999/Learning_Courses/assets/64829519/1b5618f0-85c1-42e7-80ac-d9208a8dd870)
