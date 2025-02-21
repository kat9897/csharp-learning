// Implicit type conversions
string firstName = "Bob";
int secondNumber = 7;
Console.WriteLine(firstName + " sold " + secondNumber + "widgets.");

// order of operations
string firstName = "Bob";
int secondNumber = 7;
Console.WriteLine(firstName + " sold " + (secondNumber + 7) + " widgets.");

// literal decimal data
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;
decimal decimalQuotient = 7m / 5;
// can't do
// int decimalQuotient = 7 / 5.0m;
// int decimalQuotient = 7.0m / 5;
// int decimalQuotient = 7.0m / 5.0m;
// decimal decimalQuotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);
Console.WriteLine($"Decimal Quotient: {decimalQuotient}");

// cast results to decimal
int first = 7;
int second = 5;
decimal quotient = (decimal)first / (decimal)second;
Console.WriteLine(quotient);

// Modulus = %
// order of operations
int value1 = 3 + 4 * 5;
int value2 = (3 + 4) * 5;
Console.WriteLine(value1);
Console.WriteLine(value2);

// increments
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

// can use ++1 to say add before doing it
int value = 1;
value++;
Console.WriteLine("First: " + value);
Console.WriteLine($"Second: {value++}");
Console.WriteLine("Third: " + value);
Console.WriteLine("Fourth: " + (++value));

// Challenge
int fahrenheit = 94;
decimal celsius = ((decimal)fahrenheit - 32) * (5.0m / 9.0m);
Console.WriteLine($"The temperature is {celsius} Celsius.");
