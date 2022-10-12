// My Calss to use on Foreach
// can find on the System.Collection
// has just one method GetEnumerator
// return IEnumerator -- for foreach 

using System.Collections;

MyClass myClass = new MyClass();

//for (int i = 0; i < myClass.arr.Length; i++)
//{
//	//Console.WriteLine(myClass[i]);
//}

foreach (var item in myClass)
{
    Console.WriteLine(item);
}
class MyClass : IEnumerable, IEnumerator
{
    public int[] arr = { 1, 8, 9, 10, -8, 9, 10, 10 };
    private int index = -1;
    public object Current
    {
        get { return arr[index]; }
    }

    public IEnumerator GetEnumerator()
    {
        return this;
    }

    public bool MoveNext()
    {
        if (index == arr.Length - 1)
        {
            Reset();
            return false;
        }
        index+=2;
        return true;
    }

    public void Reset()
    {
        index = -1;
    }

    //public int this[int index]
    //{
    //	get { return arr[index]; }
    //	set { /* set the specified index to value here */ }
    //}
}
