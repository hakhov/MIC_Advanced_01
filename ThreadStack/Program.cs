int count = 0;

//Thread 1
Thread thread = new Thread(() =>
{
    Console.WriteLine($"Counter from Thread1 = {++count}");
});
thread.Start();

Thread thread2 = new Thread(() =>
{
    Console.WriteLine($"Counter from Thread2 = {++count}");
});
thread2.Start();

Console.WriteLine($"Counter from Main = {count}");

///thread.Join();  
Console.ReadKey();