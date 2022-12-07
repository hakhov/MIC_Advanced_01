Thread thread = Thread.CurrentThread;
thread.Name = "Primary";

Console.WriteLine($"{thread.Name} - {thread.ManagedThreadId}");

Thread thread1 = new Thread(MyMethod);
thread1.Start();

thread1.Join();

for (int i = 0; i < 100; i++)
{
    Console.Write("=");
    Thread.Sleep(20);
}
Console.WriteLine("Primary End");


static void MyMethod()
{
    Thread thread = Thread.CurrentThread;
    thread.Name = "Secondary";

    Console.WriteLine($"{thread.Name} - {thread.ManagedThreadId}");

    for (int i = 0; i < 100; i++)
    {
        Console.Write($".");
        Thread.Sleep(20);
    }
    Console.WriteLine("Secondary End");
}