Display display = () => MyMethod();
display.Invoke();

static void MyMethod() => Console.WriteLine("Hello");

static bool MyBool() => true;

int number = 20;
MathOperation mathOperation = number => number * 2;
mathOperation.Invoke(10);


int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

int result = Sum(arr, number => number > 3);
Console.WriteLine(result);


static int Sum(int[] arr, IsEqual isEqual)
{
    int result = 0;
    foreach (var item in arr)
    {
        if (isEqual(item)) result += item;
    }

    return result;
}

delegate bool IsEqual(int number);

delegate void Display();
delegate int MathOperation(int x);

