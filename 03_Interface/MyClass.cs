using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Interface
{
    internal class MyClass : IInterface1, IInterface2
    {
        public void MethodInterface1()
        {
            Console.WriteLine("Implented MethodInterface1() as IInterface1");
        }

        public void MethodInterface2()
        {
            Console.WriteLine("Implented MethodInterface2() as IInterface2");

        }
    }
}
