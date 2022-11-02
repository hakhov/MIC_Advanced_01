int number = 10;
MyDelagate myDelagate = (ref int number) => number *= 10;
myDelagate.Invoke(ref number);

Console.WriteLine(number);

delegate void MyDelagate(ref int number);