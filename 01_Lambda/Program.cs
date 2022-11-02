MyDelegate myDelegate;// = delegate (int number) { return 2 * number; };
MyDelegate1 myDelegate1 = () => 10;
//Action action = () => myDelegate1.Invoke();
//=>
//myDelegate = (number) => { return 2 * number; };
myDelegate = number => number * 2;

int result = myDelegate.Invoke(10);
Console.WriteLine(result);



int result1 = myDelegate1.Invoke();
Console.WriteLine(result1); 

delegate int MyDelegate(int number);
delegate int MyDelegate1();