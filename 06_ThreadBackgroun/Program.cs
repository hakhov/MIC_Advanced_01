Thread thread = new Thread(MyMethod);
thread.Start();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Primaery");
    Thread.Sleep(500);
}

thread.IsBackground = true;
static void MyMethod()
{
    while (true)
    {
        Console.WriteLine(new string(' ', 10) + "Secondary");
        Thread.Sleep(500);
    }
}

