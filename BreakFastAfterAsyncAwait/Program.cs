using BreakFastAfterAsyncAwait;


var startTime = DateTime.Now;

Coffee coffee = PourCoffee();
Console.WriteLine("Coffee is ready");

HeatPan(3);

var taskEggs = FryEggsAsync(2);
var taskBacon = FryBaconAsync(3);
var taskToast = ToastBreadAsync(2);

Egg egg = await taskEggs;
Console.WriteLine("Eggs are ready:");

Bacon bacon = await taskBacon;
Console.WriteLine("Bacon is ready:");

Toast toast = await taskToast;
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
    Task.Delay(3000);
    Console.WriteLine("The pan is ready:");
}

async static Task<Egg> FryEggsAsync(int countofEggs)
{
    Console.WriteLine($"breacking {countofEggs} eggs");
    Console.WriteLine("cooking the eggs .....");
    await Task.Delay(8000);
    Console.WriteLine("Put them on the plate!");

    return new Egg();
}
async static Task<Bacon> FryBaconAsync(int countOfBeckon)
{
    Console.WriteLine($"putting {countOfBeckon} backons in the pan:");
    Console.WriteLine("cooking the backons .....");
    await Task.Delay(3000);
    Console.WriteLine("Put them on the plate!");

    return new Bacon();
}
async static Task<Toast> ToastBreadAsync(int countOfBread)
{
    Console.WriteLine($"putting {countOfBread} breads in the toaster:");
    await Task.Delay(3000);
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
