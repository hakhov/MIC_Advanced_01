
internal class MyClass : BClass, IInterface1, IInterface2
{
    public void MethodInterface1()
    {
        Console.WriteLine("Implented MethodInterface1() as IInterface1");
    }

    public void MethodInterface2()
    {
        Console.WriteLine("Implented MethodInterface2() as IInterface2");

    }
}