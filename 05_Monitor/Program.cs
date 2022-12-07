MyClass ob = new MyClass();

for (int i = 0; i < 3; i++)
{
    new Thread(ob.MyMethod).Start();
}

class MyClass
{
    object block = new object();
    public void MyMethod()
    {
        //Monitor.Enter(block);
        lock (block)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Thread  - {Thread.CurrentThread.ManagedThreadId} - {i}");
                Thread.Sleep(1000);
            }
        }
        // Monitor.Exit(block);
    }
}
