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

            List<string> lines = new List<string>(new string[] { "hello world", "press enter to exit!"});
            IDataSource dataSrc = new ListDataSource(lines);

            string data = dataSrc.NextLine();
            while(data != null) {
                display.DisplayLine(data);
                data = dataSrc.NextLine();
            }
            // Wait to exit
            Console.ReadLine();
        }
    }
}
