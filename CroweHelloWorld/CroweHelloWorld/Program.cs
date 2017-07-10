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

            // create dataSrc object
            List<string> lines = new List<string>(new string[] { "hello world " });
            IDataSource dataSrc = new ListDataSource(lines);
            dataSrc.WriteData("\n");

            display.InitDisplay();

            StringBuilder msg = new StringBuilder();
            msg.Append(dataSrc.ReadData("0"));
            msg.Append(dataSrc.ReadData("1"));
            display.DisplayLine(msg.ToString());

            display.FinishDisplay();
        }
    }
}
