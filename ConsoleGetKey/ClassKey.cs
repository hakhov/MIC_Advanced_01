using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleGetKey
{
    public class ClassKey
    {
        ConsoleKey _consoleKey;
        public ClassKey(ConsoleKey consoleKey)
        {
            _consoleKey = consoleKey;
        }

        public void GetInfo()
        {
            Console.WriteLine($"\tYou pressed {_consoleKey}");
        }
    }
}
