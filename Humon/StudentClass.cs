using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Humon
{
    internal class StudentClass : Student
    {
        private string x = "Hello";
        public void GetInfoFromStudentClass()
        {
            Console.WriteLine($"X:{x} + Age:{age}+{lname}");

        }
    }
}
