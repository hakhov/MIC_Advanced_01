List<int> list = new();
list.Add(1);
list.Add(2);
list.Add(3);

//int[] list = { 1, 2, 3, 5, };  

Print(list.GetEnumerator());

static void Print(IEnumerator<int> enumerator)
{
	while (enumerator.MoveNext())
	{
		var value = enumerator.Current;
		Console.WriteLine(value);
	}
}
