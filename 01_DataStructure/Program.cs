using System.Collections;

ArrayList arrayList = new ArrayList();
string txt = "sasdasdasd";
int x = 10;
double y = -5.6;
DateTime dateTime = DateTime.Now;

arrayList.Add(txt);
arrayList.Add(x);
arrayList.Add(y);
arrayList.Add(dateTime);

foreach (var item in arrayList)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------------------");
Hashtable hashtable= new Hashtable();
hashtable.Add("t1", "v1");
hashtable.Add("t2", "v2");
hashtable.Add("t3", "v3");
hashtable.Add("t4", "v4");
hashtable.Add("t8", "v4");

foreach (DictionaryEntry item in hashtable)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
Console.WriteLine("-------------------------");

HashSet<int> ints= new HashSet<int>();
ints.Add(2);
ints.Add(2);
ints.Add(2);
ints.Add(5);
ints.Add(2);

foreach (var item in ints)
{
    Console.WriteLine(item);
}

Console.WriteLine("-------------------------");


SortedList sortedList = new SortedList();
SortedList<int, string> arr = new SortedList<int, string>();
sortedList.Add("t1", "v1");
sortedList.Add("t2", "v56");
sortedList.Add("t3", "v3");
sortedList.Add("t8", "v4");
sortedList.Add("t4", "v4");

foreach (DictionaryEntry item in sortedList)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
Console.WriteLine("-------------------------");

Stack stack= new Stack();
stack.Push("t1");
stack.Push("t2");
stack.Push("t3");
stack.Push("t8");
stack.Push("t4");

foreach (object item in stack)
{
    Console.WriteLine($"{item}");
}
Console.WriteLine("-------------------------");

Queue queue = new Queue();

queue.Enqueue("t1");
queue.Enqueue("t2");
queue.Enqueue("t3");
queue.Enqueue("t8");
queue.Enqueue("t4");

foreach (object item in queue)
{
    Console.WriteLine($"{item}");
}
Console.WriteLine("-------------------------");

Dictionary<int, string> keyValuePairs= new Dictionary<int, string>();
keyValuePairs.Add(1, "v1");
keyValuePairs.Add(2, "v56");
keyValuePairs.Add(3, "v3");
keyValuePairs.Add(8, "v4");
keyValuePairs.Add(4, "v4");

foreach (var item in keyValuePairs)
{
    Console.WriteLine($"{item.Key} - {item.Value}");
}
Console.WriteLine("-------------------------");