//foreach (var item in GetNumbers())
//{
//	Console.WriteLine(item);
//}

MyClass myClass = new MyClass();

foreach (var item in myClass.GetEnumerator())
{
    var item1 = item + "Hello";
    Console.WriteLine(item);
}

foreach (var item in myClass.GetSqareNumbers(2,-2,50))
{
    Console.WriteLine(item);
}
static IEnumerable<int> GetNumbers()
{
    var number = 0;
    while (true)
    {
        if (number > 20)
            yield break;

        yield return number++;
    }
}

class MyClass
{
    string[] arr = { "Hakob", "Hayk", "Lilit", "Asya", "Narek", "Gayane" };

    public IEnumerable<string> GetEnumerator()
    {
        yield return arr[0];
        yield return arr[1];
        yield return arr[2];
        yield return arr[3];
        yield return arr[4];
        yield return arr[5];
    }

    public IEnumerable<double> GetSqareNumbers(double a, double b, double c)
    {
        double x1, x2;
        double D = Math.Pow(b, 2) - 4 * a * c;

        if (D < 0) yield return 0;

        x1 = (-b + Math.Sqrt(D) / 2 * a);
        x2 = (-b - Math.Sqrt(D) / 2 * a);

        yield return x1;
        yield return x2;
    }
}