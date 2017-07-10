using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorld
{
    class ListDataSource : IDataSource
    {
        private List<string> _lines;

        public ListDataSource(List<string> lines)
        {
            _lines = new List<string>();
            // create shallow copy to avoid external mutation of the list.
            for (int i = 0; i < lines.Count; i++)
            {
                _lines.Add(lines[i]);
            }
        }

        public string ReadData(string arg)
        {
            int index = int.Parse(arg);
            return _lines[index];
        }

        public void WriteData(string arg)
        {
            _lines.Add(arg);
        }
    }
}
