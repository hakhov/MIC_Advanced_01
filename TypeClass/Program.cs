
MyClass myClass = new MyClass();
Type type;

type= myClass.GetType();
Console.WriteLine(type);

type = Type.GetType("MyClass");
Console.WriteLine(type);


type = typeof(MyClass);
Console.WriteLine(type);
class MyClass
{

}