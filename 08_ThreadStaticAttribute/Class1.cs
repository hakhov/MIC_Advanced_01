
partial class Program
{
    [ThreadStatic]
    static int counter = 0;

    static void MyMethod()
    {
        if (counter < 50)
        {
            ++counter;
            Console.WriteLine($"{counter} - ID = {Thread.CurrentThread.ManagedThreadId}");

            var thread = new Thread(MyMethod);
            thread.Start();
            thread.Join();
        }

        Console.WriteLine($"Thread from MyMtehod - {Thread.CurrentThread.ManagedThreadId}");
    }
}
