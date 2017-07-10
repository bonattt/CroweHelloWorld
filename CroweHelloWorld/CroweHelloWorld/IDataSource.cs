using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorld
{
    interface IDataSource
    {
        // Returns the next line of data from the source
        // returns null if there is no more data to display
        string NextLine();

        // Resets the Datasource to the beginning
        void Reset();
    }
}
