Test();
Console.ReadKey();

static void Test()
{
    Calc();
    Calc3(); 
}

async static Task Calc()
{
    var result = await Task.Run(() =>
    {
        return Calc1();
    });

    Calc2(result);

}
static int Calc1()
{
    Thread.Sleep(5000);
    Console.WriteLine("Calc1");
    return 1;
}

static int Calc2(int number)
{
    Console.WriteLine("Calc2");
    return number + 10;
}

static int Calc3()
{
    Console.WriteLine("Calc3");
    return 3;
}

