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
            IDataDisplay display = new ConsoleDisplay("press enter to exit", true);
            

            List<string> lines = new List<string>(new string[] { "hello world" });
            IDataSource dataSrc = new ListDataSource(lines);

            display.InitDisplay();
            string data = dataSrc.NextLine();
            while(data != null) {
                display.DisplayLine(data);
                data = dataSrc.NextLine();
            }
            // Wait to exit
            display.FinishDisplay();
        }
    }
}
