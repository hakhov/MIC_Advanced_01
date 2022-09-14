using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Inheritance
{
    public class Base
    {
        public int X { get; set; } = 20;
        public int Y { get; set; } = 50;
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"{X} - {Y}");
        }
    }
}
