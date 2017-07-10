using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorld
{
    class ConsoleDisplay : IDataDisplay
    {
        private string _exitMessage = "press enter to exit!";
        // Read only property allows you to see what the exit message is.
        public string exitMessage {
            get { return _exitMessage; }
        }

        private bool _waitToExit;
        public bool waitToExit {
            get { return _waitToExit; }
        }

        public ConsoleDisplay(string exitMessage, bool waitToExit)
        {
            _exitMessage = exitMessage;
            _waitToExit = waitToExit;
        }        

        public void InitDisplay()
        {
            // this step is not necissary for the console display.
        }

        public void DisplayLine(string msg)
        {
            Console.WriteLine(msg);
        }

        public void FinishDisplay()
        {   
            // prints the exit message and waits for the user to press enter 
            Console.WriteLine(_exitMessage);
            if (_waitToExit)
            {
                Console.ReadLine();
            }
        }
    }
}
