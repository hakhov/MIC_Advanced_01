using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Constructor
{
    internal class Student
    {
        public string name;
        public int age;

        public void GetStudentInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        public Student(string n = "Hello", int a = 80)
        {
            name = n;
            age = a;
        }
        //public Student()
        //{

        //}

        //public Student(string n)
        //{
        //    name = n;
        //}
    }
}
