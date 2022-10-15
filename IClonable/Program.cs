MyClass myClass1 = new("Tom", 20);
MyClass myClass2 = (MyClass)myClass1.Clone();

Console.WriteLine(myClass1);
Console.WriteLine(myClass2);

Console.WriteLine("************************************");

myClass2.Name = "Bob";
myClass2.student.Age = 100;

Console.WriteLine(myClass1);
Console.WriteLine(myClass2);

class MyClass : ICloneable
{
    public string Name;
    public Student student = new Student();
    public object Clone()
    {
        MyClass obTemp = (MyClass)this.MemberwiseClone();
        
        Student obTempStudent = new Student();

        obTempStudent.Age = this.student.Age;
        obTemp.student = obTempStudent;

        return obTemp;
        //return this.MemberwiseClone();
    }

    public override string ToString()
    {
        return String.Format($"{Name}, {student.Age}");
    }

    public MyClass(string name, int age)
    {
        Name = name;
        this.student.Age = age;
    }
}

class Student
{
    public int Age;
}
