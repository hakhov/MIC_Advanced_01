using System;

namespace _07_ref
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            GetInfo(ref x);
            Console.WriteLine(x);

        }

        static void GetInfo(ref int x)
        {
            x = 20;
            Console.WriteLine(x);
        }
    }
}
