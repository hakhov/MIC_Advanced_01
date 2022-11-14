Record1 record1 = new("Test1", 10);
Record1 record2 = new("Test1", 10);
Record1 record3 = new("Test3", 30);

Console.WriteLine("Record Type:");
Console.WriteLine($"To String: {record1}");
Console.WriteLine($"Equal: {Equals(record1, record2)}");
Console.WriteLine($"ReferanceEqual: {ReferenceEquals(record1, record2)}");
Console.WriteLine($"HashCode: {record1.GetHashCode()}");
Console.WriteLine($"HashCode: {record2.GetHashCode()}");
Console.WriteLine($"HashCode: {record3.GetHashCode()}");
Console.WriteLine($"==: {record1 == record2}");
Console.WriteLine($"==: {record2 == record3}");


Console.WriteLine("----------------------------------------");


MyClass myClass1 = new("Test1", 10);
MyClass myClass2 = new("Test1", 10);
MyClass myClass3 = new("Test3", 30);

Console.WriteLine("CLass Type:");
Console.WriteLine($"To String: {myClass1}");
Console.WriteLine($"Equal: {Equals(myClass1, myClass2)}");
Console.WriteLine($"ReferanceEqual: {ReferenceEquals(myClass1, myClass2)}");
Console.WriteLine($"HashCode: {myClass1.GetHashCode()}");
Console.WriteLine($"HashCode: {myClass2.GetHashCode()}");
Console.WriteLine($"HashCode: {myClass3.GetHashCode()}");
Console.WriteLine($"==: {myClass1 == myClass2}");
Console.WriteLine($"==: {myClass2 == myClass3}");


Console.WriteLine("++++++++++++++++++++++++++++++++");
var record4 = record2 with { name = "Bob"};
Console.WriteLine(record2);
Console.WriteLine(record4);
Console.WriteLine(record2 == record4);

var myClass4 = myClass2;
Console.WriteLine(myClass2);
Console.WriteLine(myClass4);
Console.WriteLine(myClass2 == myClass4);


string x1 = "Hello";
string x2 = "Hello";
Console.WriteLine(Equals(x1, x2));
Console.WriteLine(ReferenceEquals(x1, x2));
Console.WriteLine(x1 == x2);




record Record1(string name, int age);
class MyClass
{
    public int Age { get; init; }
    public string? Name { get; init; }

    public MyClass(string? name, int age)
    {
        Age = age;
        Name = name;
    }
}
