using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_withNew
{
    internal class ClassA
    {
        public ClassB FunctionA()
        {
            return new ClassB();
        }
    }
}
