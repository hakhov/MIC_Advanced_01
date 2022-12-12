
Calc();
Console.ReadKey();

static void Calc()
{
    var task1 = Task.Run(() =>
    {
        return Calc1();
    });

    var task2 = Task.Run(() =>
    {
        return Calc2();
    });

    Task.WaitAll(task1, task2);

    var awaiter1 = task1.GetAwaiter();
    var awaiter2 = task2.GetAwaiter();

    var result1 = awaiter1.GetResult();
    var result2 = awaiter2.GetResult();

    var task3 = Task.Run(() =>
    {
       return Calc3(result1, result2);
    });
    Console.WriteLine(task3.GetAwaiter().GetResult());

}
static int Calc1()
{
    Thread.Sleep(5000);
    Console.WriteLine("Calc1");
    return 1;
}

static int Calc2()
{
    Console.WriteLine("Calc2");
    return 2;
}

static int Calc3(int number1, int number2)
{
    Console.WriteLine("Calc3");
    return number1 + number2;
}
