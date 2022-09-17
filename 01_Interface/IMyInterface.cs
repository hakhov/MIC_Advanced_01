using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Interface
{
    internal interface IMyInterface
    {
        const int a = 20;
        int Prop { get; set; }
        double this[int number] { get;set; }
        void GetMove()
        {
            Console.WriteLine("Hello");
        }
        event Action e;

        public IMyInterface()
        {

        }
        int x;
    }
}
