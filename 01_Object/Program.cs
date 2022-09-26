using System.Diagnostics.CodeAnalysis;

MyClass myClass1 = new MyClass(20, "Tom");
MyClass myClass2 = new MyClass(20, "Tom");

MyClass myClass3 = myClass1;

Console.WriteLine($"GetType - {myClass1.GetType()}");
Console.WriteLine($"GetType - {myClass2.GetType()}");

Console.WriteLine($"GetHashCode - {myClass1.GetHashCode()}");
Console.WriteLine($"GetHashCode - {myClass3.GetHashCode()}");

Console.WriteLine($"Equals - {myClass3.Equals(myClass1)}");
Console.WriteLine($"Equals - {Equals(myClass1,myClass3)}");

Console.WriteLine($"ReferenceEquals - {ReferenceEquals(myClass1, myClass3)}");


class MyClass 
{
    public int Age;
    public string Name;

    public MyClass(int age, string name)
    {
        Age = age;
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        return true;
    }

    public override int GetHashCode()
    {
        return Age.ToString().GetHashCode();
    }
}
