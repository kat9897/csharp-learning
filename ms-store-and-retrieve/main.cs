// Literal value = any constant hard-coded value
/*
Data types

'' = char or single alphanum character
"" = str or string
# = int or integer
true/false = bool or boolean

Decimal #'s
#.##F = float with ~6-9 digits (F = literal suffix)
#.## = double with ~15-17 digits
#.##m = decimal with 28-29 digits
*/
Console.WriteLine('b');
Console.WriteLine("Hello World!");
Console.WriteLine(123);

Console.WriteLine(12.398F);
Console.WriteLine(12.398);
Console.WriteLine(12.39816m);

// Declaring variables needs the datatype and name
// Naming a variables should be camelCase and not start with an _
string firstName;
firstName = "Bob";
// Assignment Operator = "="
Console.WriteLine(firstName);

// Assign (set) a value to a variable before getting the variable value
// Can implicitly set a variable's data type by using "var" (always need to set this value for this to work)
var message = "Hello";

string name = "Bob";
int num = 3;
float num2 = 34.4F;
Console.Write("Hello, ");
Console.Write(name);
Console.Write("! You have ");
Console.Write(num);
Console.Write(" messages in your inbox. The temperature is ");
Console.Write(num2);
Console.Write(" celsius.");
