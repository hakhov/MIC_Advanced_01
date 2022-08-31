var x = "";
var number = (10, 50);
Console.WriteLine(number.Item1);
Console.WriteLine(number.Item2);
Console.WriteLine(number.Item2 + number.Item1);

(int, int) number2 = (-50, 80);
number.Item1 = 100;

Console.WriteLine(number2.Item1 + number.Item1);
Console.WriteLine("-------------------");

//(double, string) xx = (double.Parse(Console.ReadLine()), Console.ReadLine());
//Console.WriteLine(xx.Item1);
//Console.WriteLine(xx.Item2);

(int, double, string, char) yy = (10, 2.5, "Hello", 'c');
var yy1 = (10, 2.5, "Hello", 'c');

var (_, age, _, hight) = GetInfo("New York City", 1960, 180);
Console.WriteLine(age);

(string, int, double, int) GetInfo(string v1, int v2, double v3)
{
    return (v1, v2, v3, 50);
}

(double color, double colorHEX) numbers = (12.5, 10.8); // test
Console.WriteLine(numbers.color);
