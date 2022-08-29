using BenchmarkDotNet.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_BoxingUnboxingTest
{
    [MemoryDiagnoser]
    public class BoxingTest
    {
        [Benchmark]
        public void WithOutBoxing()
        {
            int a = 0;
            int b = 10;
            a -= b;
        }

        [Benchmark]
        public void WithBoxing()
        {
            int a = 0;
            object b = 10;
            a -= (int)b;
        }
    }
}
