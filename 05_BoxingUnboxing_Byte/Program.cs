byte num1 = 2;
byte num2 = 255;

//num1 = (byte)(num1 - num2);
//Console.WriteLine(num1);

num1 = (byte)(num1 + num2);
Console.WriteLine(num1);

int a = int.MaxValue;
//a = a + 1;
//Console.WriteLine(a);

int b = int.MinValue;
b = b - 1;
Console.WriteLine(b);

checked
{
    a=a+1;
}

Console.WriteLine(a);


