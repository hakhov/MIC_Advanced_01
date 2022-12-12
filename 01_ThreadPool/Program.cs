int maxThreadPool;
int inOut;

ThreadPool.GetMaxThreads(out maxThreadPool, out inOut);
Console.WriteLine($"Max Threads: {maxThreadPool}");
Console.WriteLine($"Max I/O: {inOut}");


ThreadPool.GetMinThreads(out maxThreadPool, out inOut);
Console.WriteLine($"Max Threads: {maxThreadPool}");
Console.WriteLine($"Max I/O: {inOut}");


Console.WriteLine($"ProcessorId - {Thread.GetCurrentProcessorId()}");
Console.WriteLine($"ManagedThreadId - {Thread.CurrentThread.ManagedThreadId}");


for (int i = 0; i < 25; i++)
{
    ThreadPool.QueueUserWorkItem(Info);
    //new Thread(() =>
    //{
    //    Console.WriteLine($"Display pool thread: {Thread.CurrentThread.ManagedThreadId}");
    //}).Start();
   
}

Console.ReadKey();

void Info(object? state)
{
    Console.WriteLine($"Display pool thread: {Thread.CurrentThread.ManagedThreadId}");
}