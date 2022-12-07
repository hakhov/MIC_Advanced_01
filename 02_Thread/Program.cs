Thread thread = Thread.CurrentThread;
thread.Name = "Primary";

Console.WriteLine($"{thread.Name} - {thread.ManagedThreadId}");

Thread threadSecondary = new Thread(MyMethod);
threadSecondary.Start();

for (int i = 0; i < 20; i++)
{
    Console.WriteLine($" - {thread.Name} - {i}");
    Thread.Sleep(1200);
}

Console.WriteLine("Main End");

static void MyMethod()
{
    Thread thread = Thread.CurrentThread;
    thread.Name= "Secondary";

    Console.WriteLine($"{thread.Name} - {thread.ManagedThreadId}");
    for (int i = 0; i < 35; i++) 
    {
        Console.WriteLine($"{new string(' ', 20)} - {thread.Name} - {i}");
        Thread.Sleep(1000);
    }
    Console.WriteLine("Secondary End");
}