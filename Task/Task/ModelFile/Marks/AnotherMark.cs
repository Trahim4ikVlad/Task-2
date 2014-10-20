using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    class AnotherMark:IMark
    {
        private IList<char> _Marks = new List<char>()
        {   
        };

        public char Value { get; set; }

        public bool Contains(char ch)
        {
            if (_Marks.Contains(ch))
                return true;
            return false;
        }
        public IList<char> GetMarks()
        {
            return _Marks;
        }
    }
}
