using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorld
{
    interface IDataSource
    {
        // reads data based on the string arguement (ie. an SQL query)
        string ReadData(string arg);

        // writes data to the data source based on the string argument (ie. an SQL query)
        void WriteData(string arg);
    }
}
