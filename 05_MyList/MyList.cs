public class MyList<T>
{
    private T[] data;
    private int size = 0;
    private int capacity;

    public MyList(int intialCapacity = 2)
    {
        if (intialCapacity < 1) intialCapacity = 1;

        this.capacity = intialCapacity;
        data = new T[intialCapacity];
    }

    public int Size { get { return size; } }
    public bool IsEmpty { get { return size == 0; } }

    public T GetAtElement(int index)
    {
        ThrowIfIndexOutOfRange(index);
        return data[index];
    }

    public void SetAtElement(int index, T newElement)
    {
        ThrowIfIndexOutOfRange(index);
        data[index] = newElement;
    }

    private void ThrowIfIndexOutOfRange(int index)
    {
        if (index > size - 1 || index < 0)
            throw new ArgumentOutOfRangeException("This index iz not vaild");
    }

    public void Add(T item)
    {
        if (size == capacity)
            Resize();

        data[size++] = item;
    }

    private void Resize()
    {
        T[] resizedArray = new T[2 * capacity];
        for (int i = 0; i < capacity; i++)
        {
            resizedArray[i] = data[i];
        }
        data = resizedArray;
        capacity = capacity * 2;
    }

    public void InsertAtElement(int index, T newElement)
    {
        ThrowIfIndexOutOfRange(index);

        if (size == capacity)
            Resize();

        for (int i = size; i > index; i--)
        {
            data[i] = data[i - 1];
        }
        data[2] = (T);

        data[index] = newElement;
        size++;
    }

    public void DeleteAtElement(int index)
    {
        //do implement
    }

    public bool Contains(T value)
    {
        //do implement
        return false;
    }

    public void Clear()
    {
        // do implemenet
    }
}