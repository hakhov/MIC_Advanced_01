int a = 300;
int b = 200;

if (a > b)
{
    Console.WriteLine("is great");
}
else
{
    Console.WriteLine("No");
}

MyClass myClass1 = new();
MyClass myClass2 = new();

if (myClass1.Age > myClass2.Age)
{

}
Console.WriteLine(myClass1.CompareTo(myClass2));

string txt1 = "A";
string txt2 = "a";
txt1.CompareTo(txt2);
class MyClass : IComparable
{
    public int Age;

    public static bool operator >(MyClass ob1, MyClass ob2)
    {
        if (ob1.Age > ob2.Age)
        {
            return true;
        }

        return false;
    }

    public static bool operator <(MyClass ob1, MyClass ob2)
    {
        if (ob1.Age > ob2.Age)
        {
            return false;
        }

        return true;
    }

    /// <summary>
    /// This methode can compare to MyClass type instaces.
    /// is zero - 1
    /// -1
    /// 0
    /// </summary>
    /// <param name="obj">sdffds</param>
    /// <returns> retur int</returns>
    public int CompareTo(object? obj)
    {
        MyClass ob1 = (MyClass)obj;

        if (Age > ob1?.Age)
            return 1;

        if (Age < ob1?.Age)
            return -1;

        return 0;
    }
}