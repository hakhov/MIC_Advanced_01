
Action action = MyMethod;

action += () => { Console.WriteLine("from lambda"); };
action.Invoke();

Action<int> newAction = number => Console.WriteLine(2 * number);
newAction(10);

newAction += MyMethod1;
newAction(40);

Func<int, int, int> add = Sum;
Console.WriteLine(add(10, 20));

int Sum(int x, int y)
{
    return x + y;
}

void MyMethod()
{
    Console.WriteLine("Hello");
}

void MyMethod1(int number)
{
    Console.WriteLine(2 * number);
}