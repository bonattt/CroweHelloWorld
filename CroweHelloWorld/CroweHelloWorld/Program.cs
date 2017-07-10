using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            IDataDisplay display = new ConsoleDisplay();
            display.DisplayLine("Hello World");
            display.DisplayLine("press enter to exit!");
            Console.ReadLine();
        }
    }
}
