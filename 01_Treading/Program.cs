//Thread primaryThread = Thread.CurrentThread;
//Console.WriteLine($"Thrade ID = {primaryThread.ManagedThreadId}");

using System.Diagnostics;
using System.Threading;

//ThreadStart threadStart = new ThreadStart(MyMethod);
//Thread thread = new Thread(threadStart);
//thread.Start();

//Thread thread = new Thread(MyMethod);
//thread.Start();
Thread thread = new Thread(
    ()=>
    {
        while (true)
        {
            Console.WriteLine(new string(' ', 10) + "Secondary");
        }
    });
thread.Start();

while (true)
{
    Console.WriteLine("Primary");
}

static void MyMethod()
{
    while (true)
    {
        Console.WriteLine(new string(' ', 10) + "Secondary");
    }
}
