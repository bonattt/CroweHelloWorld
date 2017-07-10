using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorld
{
    interface IDataDisplay
    {
        // called before inputing data to perform setup, such as establishing a network connection.
        void InitDisplay();

        void DisplayLine(string msg);

        // called after inputing data lines. Does any necissary steps at the end of the display
        // such as safely closing web Sockets.
        void FinishDisplay();
    }
}
