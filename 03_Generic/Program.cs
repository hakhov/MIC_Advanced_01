Lunch<Product> ob = new Lunch<Product>();
Lunch<Orange> orange = new Lunch<Orange>();
Lunch<Brad> brad = new Lunch<Brad>();
Brad ob1 = new Brad(20, "20", 30);
brad.Add(ob1);
Console.WriteLine(brad.LunchPrice);

MyDeleget<int> myDeleget = new MyDeleget<int>(MyMethodInt);
myDeleget.Invoke(50);


MyDeleget<string> myDeleget2 = new MyDeleget<string>(MyMethodString);
myDeleget2.Invoke("50");
static void MyMethodInt(int arg)
{
    Console.WriteLine(10 * arg);
}

static void MyMethodString(string arg)
{
    Console.WriteLine(arg);
}
class Product
{
    public int Weght { get; set; }
    public string? Name { get; set; }
    public int Price { get; set; }

    public Product(int weght, string? name, int price)
    {
        Weght = weght;
        Name = name;
        Price = price;
    }
}

class Orange : Product
{
    public Orange(int weght, string? name, int price) : base(weght, name, price)
    {

    }
}

class Brad : Product
{
    public Brad(int weght, string? name, int price) : base(weght, name, price)
    {

    }
}

class Lunch<T> where T : Product
{
    public int LunchPrice { get; set; }
    public void Add(T product)
    {
        LunchPrice += product.Price;
    }

}


class MathC<T> where T : IComparable
    //where struct
    //Class
    //new()
{
    //public T GetMax<T>(T a, T b) where T : IComparable
    //{
    //    return a.CompareTo(b) > 0 ? a : b;
    //}

    public T GetMax<T>(T a, T b) where T : IComparable
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    public T GetMin<T>(T a, T b) where T : IComparable
    {
        return a.CompareTo(b) < 0 ? a : b;
    }
}

public delegate void MyDeleget<T>(T arg);

