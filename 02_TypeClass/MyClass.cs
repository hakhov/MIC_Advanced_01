
public class MyClass:IIterface1, IIterface2
{
  public int myInt;
  private string myString = "Hello";

  public MyClass()
  {

  }

  public MyClass(int myint)
  {
    myInt= myint;
  }

  public int myProp
  {
    get { return myInt; }
    set { myInt = value; }
  }

  public string MyProperty { get; }

  public void Method1()
  {
    Console.WriteLine("Method1");
  }

  public void Method2()
  {
    Console.WriteLine("Method2");

  }
}