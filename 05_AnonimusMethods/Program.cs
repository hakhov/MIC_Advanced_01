//MyDelaget myDelaget = new MyDelaget(
//    delegate// private void MyMethod()
//    {
//        Console.WriteLine("Hello mrom here!");
//    }
//    );

MyDelaget myDelaget = delegate
    {
        Console.WriteLine("Hello mrom here!");
    };
myDelaget.Invoke();


MyDelagetWithParametor myDelagetWithParametor = (int a, int b) => a + b;
int result = myDelagetWithParametor.Invoke(20, 20);
Console.WriteLine(result);

public delegate void MyDelaget();
public delegate int MyDelagetWithParametor(int x, int y);

