using System;

namespace _01_Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            MyClass[] arr = new MyClass[];
            arr.

            for (int i = 0; i < 10; i++)
            {
                myClass[i] = i + "+index";
                Console.WriteLine(myClass[i]);
            }
        }
    }
    class MyClass
    {
        string[] arr = new string[10];
        string[] arr1 = new string[10];
        public string this[int index]
        {
            get { return arr1[index]; }
            set { arr1[index] = value; }
        }
    }
}
