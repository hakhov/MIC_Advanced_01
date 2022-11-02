using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_this
{
    internal class Student
    {
        public string name;
        public int age;
        public int id;

        public void GetStudentInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        public Student(string n, int a) : this(a)
        {
            name = n;
        }
        public Student(string n, int a, int id) : this(n, id)
        {
            this.id = id;
        }
        public Student()
        {

        }

        public Student(string n)
        {
            name = n;
        }
        public Student(int age)
        {
            this.age = age;
        }

        //public Student(byte id)
        //{

        //}
    }
}
