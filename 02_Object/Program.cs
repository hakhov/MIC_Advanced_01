using System;

namespace _02_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A obA = new A() { Name = "Tom"};
            MyClass myClass1 = new MyClass(){ RefereanceType = obA, Age = 20 };
            MyClass myClass2 = myClass1.MyMethod(myClass1);

            //MyClass myClass3 = myClass1;


            //Console.WriteLine(myClass1.Age);
            //Console.WriteLine(myClass3.Age);

            //myClass1.Age = 50;
            //Console.WriteLine("-----------------------");
            //Console.WriteLine(myClass1.Age);
            //Console.WriteLine(myClass3.Age);


            Console.WriteLine("*************************");

            Console.WriteLine(myClass1.Age);
            Console.WriteLine(myClass2.Age);

            myClass1.Age = 50;
            Console.WriteLine("-----------------------");
            Console.WriteLine(myClass1.Age);
            Console.WriteLine(myClass2.Age);
            Console.WriteLine("-----------------------");

            Console.WriteLine(myClass1.RefereanceType.Name);
            Console.WriteLine(myClass2.RefereanceType.Name);

            myClass1.RefereanceType.Name = "Bob";
            Console.WriteLine("xxxxxxxxxxxxxxxxxxx");

            Console.WriteLine(myClass1.RefereanceType.Name);
            Console.WriteLine(myClass2.RefereanceType.Name);

        }
    }

    struct MyClass
    {
        public int Age;
        //public string Name;

        public A RefereanceType;
        public MyClass MyMethod(MyClass myClass)
        {
            //MyClass myClass1 = new MyClass();
            //MyClass myClass2 = new MyClass();

            return (MyClass)myClass.MemberwiseClone();
        }
    }

    struct A
    {
        public string Name;
    }
}
