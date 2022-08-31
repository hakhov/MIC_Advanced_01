using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var (_, _, _, pop1, _, pop2) = (_, _, _,1960, _,2010);
            var (_, _, _, pop1, _, pop2) = (1960, _,2010);
        }
    }
}
