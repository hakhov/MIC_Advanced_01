// See
var x = GetSum(("Hello", 120), 5);
Console.WriteLine(x);

static int GetSum((string, int) t, int a)
{
    return a + t.Item2;
}
