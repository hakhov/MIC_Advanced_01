Thread th = Thread.CurrentThread;
th.Name = "Primery";

Console.WriteLine($"{th.Name} - {th.ManagedThreadId}");

ParameterizedThreadStart parameterizedThread = MyMethod;
Thread thread = new Thread(parameterizedThread);
thread.Start("Hello MIC");

Thread.Sleep(500);

Console.WriteLine("Primary End");



static void MyMethod(object? obj)
{
    Thread thread = Thread.CurrentThread;
    thread.Name = "Secondary";

    Console.WriteLine($"{thread.Name} - {thread.ManagedThreadId}");

    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine($"{obj} - {thread.Name} - {i}");
        Thread.Sleep(500);
    }
    Console.WriteLine("Secondary End");
}
