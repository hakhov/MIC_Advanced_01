using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Class_Object
{
    internal class Student
    {
        public string name;
        public int age;

        public void GetStudentInfo()
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }
    }
}
