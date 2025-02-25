Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

// Stateless (static) method doesn't need an instance of a class (object), so it can be called with the class itself
// Stateful (instance) method needs an object

// Quiet methods mean they don't return anything (void methods)

// Arguments are concrete values you pass through a method 
// Parameter is the variable that's being used inside the method
// Method signature defines # and type of parameters accepted by method
// Overloaded methods have multiple method signatures (can accept different combos of parameters)

int number = 7;
string text = "seven";

Console.WriteLine(number);
Console.WriteLine();
Console.WriteLine(text);

Random dice2 = new Random();
int roll1 = dice2.Next();
// Sky's the limit
int roll2 = dice2.Next(101);
// Sets upper bound
int roll3 = dice2.Next(50, 101);
// Sets lower and upper bound

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

// Math class methods challenge
int firstValue = 500;
int secondValue = 600;
int largerValue;
largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);