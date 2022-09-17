
internal class MyClass : IInterface1, IInterface2
{
    void IInterface1.MethodInterface()
    {
        Console.WriteLine("Implented MethodInterface() as IInterface1");
    }

    void IInterface2.MethodInterface()
    {
        Console.WriteLine("Implented MethodInterface() as IInterface2");

    }
}
