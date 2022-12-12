

using BreakFastBeforAsyncAwait;

var startTime = DateTime.Now;

Coffee coffee = PourCoffee();
Console.WriteLine("Coffee is ready");

HeatPan(3);

Egg egg = FryEggs(2);
Console.WriteLine("Eggs are ready:");

Bacon becon = FryBacon(3);
Console.WriteLine("Bacon is ready:");

Toast toast = ToastBread(2);
ApplyJam(toast);

Console.WriteLine("Toast is ready:");

Juice juice = PourJuice();

Console.WriteLine("Juice is ready:");

Console.WriteLine("BreakFast is ready!");

var endTime = DateTime.Now;

Console.WriteLine($"Total time for breakfast: {(endTime - startTime).Seconds} second");



static Coffee PourCoffee()
{
    Console.WriteLine("Pouring coffee");
    return new Coffee();
}

static void HeatPan(int degree)
{
    Task.Delay(3000) ;
    Console.WriteLine("The pan is ready:");
}

static Egg FryEggs(int countofEggs)
{
    Console.WriteLine($"breacking {countofEggs} eggs");
    Console.WriteLine("cooking the eggs .....");
    Task.Delay(8000).Wait();
    Console.WriteLine("Put them on the plate!");

    return new Egg();
}
static Bacon FryBacon(int countOfBeckon)
{
    Console.WriteLine($"putting {countOfBeckon} backons in the pan:");
    Console.WriteLine("cooking the backons .....");
    Task.Delay(3000).Wait();
    Console.WriteLine("Put them on the plate!");

    return new Bacon();
}
static Toast ToastBread(int countOfBread)
{
    Console.WriteLine($"putting {countOfBread} breads in the toaster:");
    Task.Delay(3000).Wait();
    Console.WriteLine("Put them on the plate!");

    return new Toast();
}
static void ApplyJam(Toast toast)
{
    Console.WriteLine("Putting jam on the toast");
}

static Juice PourJuice()
{
    Console.WriteLine("Pouring apple juice:");
    return new Juice();
}
