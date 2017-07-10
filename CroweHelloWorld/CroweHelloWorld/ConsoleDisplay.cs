using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorld
{
    class ConsoleDisplay : IDataDisplay
    {
        public void DisplayLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
