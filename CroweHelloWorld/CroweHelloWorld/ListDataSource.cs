using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CroweHelloWorld
{
    class ListDataSource : IDataSource
    {
        private string[] _lines;
        private int _index;

        public ListDataSource(List<string> lines)
        {
            _lines = new string[lines.Count];
            // create shallow copy to avoid external mutation of the list.
            for (int i = 0; i < lines.Count; i++)
            {
                _lines[i] = lines[i];
            }
            _index = 0;
        }

        public string NextLine()
        {
            if (_index >= _lines.Length)
            {
                return null;
            }
            return _lines[_index++];
        }

        public void Reset()
        {
            _index = 0;
        }
    }
}
