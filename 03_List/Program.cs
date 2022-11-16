
List<string> strings = new List<string>(5) { "Tom", "Bob", "Sara" };
strings.Add("Jeremy");

var arr1 = new List<string> { "a", "2", "5" };
strings.AddRange(new List<string> { "aaaa", "2aaaa", "aaaaa5" });


List<Person> arr = new List<Person>()
{
    new Person() { Age = 20},
    new Person(50)
};

List<int> ints = new List<int>(20);
Console.WriteLine(ints.Count);
Console.WriteLine(strings.Count);


foreach (var item in strings)
{
    Console.WriteLine(item);
}
Console.WriteLine();

var x = new List<string>();
var existElement = strings.Exists(x => x.Length <= 2);
var findElement = strings.Find(x => x.Length == 1);
var findAllElement = strings.FindAll(x => x.Length == 3);

if (x is not null)
{
    var firstElm = x.First(x => x);
}

foreach (var item in findAllElement)
{
    Console.WriteLine(item);
}

Console.WriteLine("-----------------------");
Console.WriteLine(findElement);
Console.WriteLine(existElement);
class Person
{
    public int Age { get; set; }
    public Person(int age)
    {
        Age = age;
    }

    public Person()
    {

    }
}

