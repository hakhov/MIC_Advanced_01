using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Inheritance
{
    public class Child : Base 
    {
        public string Name { get; set; } = "MIC class";

        public override void DisplayInfo()
        {
            Console.WriteLine(Name);
        }
    }
}
