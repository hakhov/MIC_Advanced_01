
using Calculate;
Console.WriteLine("Please insert two numbers for Calculation:");

Calc calculate = new();
double number1 = 0, number2 = 0;

Console.Write("Number one = ");
string number = Console.ReadLine().Trim().ToLower();

if (calculate.ValidNumber(number))
    number1 = double.Parse(number);

Console.Write("Number two = ");
number = Console.ReadLine().Trim().ToLower();

if (calculate.ValidNumber(number))
    number2 = double.Parse(number);

Console.WriteLine("Please insert operation for these two numbers");
Console.Write("Operation = ");

string operation = Console.ReadLine().Trim().ToLower();

switch (operation)
{
    case "add":
        Console.WriteLine("Result = " + calculate.Add(number1, number2));
        break;
    case "sub":
        Console.WriteLine("Result = " + calculate.Sub(number1, number2));
        break;
    case "mul":
        Console.WriteLine("Result = " + calculate.Mul(number1, number2));
        break;
    case "div":
        Console.WriteLine("Result = " + calculate.Div(number1, number2));
        break;
}

