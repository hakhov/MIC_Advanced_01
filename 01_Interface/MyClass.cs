using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface
{
    internal class MyClass : IMyInterface
    {
        public double this[int number] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Prop { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event Action e;

       
    }
}
