using Calculate;

MyClass ob = new MyClass();
ob.MyMethod2();
ob.MyMethod3();
ob.MyMethod4();

Calc ob1 = new();
Console.WriteLine(ob1.GetDisgits());
string txt = "sadads".ToUpperJustFirstLetterCase();

static class NewExtentionsForMyClass
{
    public static void MyMethod4(this MyClass ob)
    {
        Console.WriteLine("MyMethod4");
    }

    public static int GetDisgits(this Calc ob)
    {

        return !string.IsNullOrEmpty(ob.ToString()) ? ob.ToString().Length : 0;
    }
}