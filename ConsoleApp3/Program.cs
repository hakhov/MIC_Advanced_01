int number1 = 1;
int number2 = 2;
int result;

MyDelagate myDelagate = delegate(ref int a, ref int b, out int c) { a++; b++; c = a + b; };

myDelagate.Invoke(ref number1, ref number2, out result);

Console.WriteLine($"{number1} + {number2} = {result}");


public delegate void MyDelagate(ref int number1, ref int number2, out int result);
