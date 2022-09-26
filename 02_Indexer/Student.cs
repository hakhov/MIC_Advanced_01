
public  class Student
{
    Person[] arr;

	public Student()
	{
		arr = new Person[10];
	}

	public Person this[int index]
	{
		get { return arr[index]; }
		set { arr[index] = value; }
	}
}