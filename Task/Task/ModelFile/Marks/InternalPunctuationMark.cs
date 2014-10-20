using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile.Marks
{
    public class InternalPunctuationMark:PunctuationMark
    {
       private IList<char> _Marks = new List<char>()
       {
       }; 

        public override bool Contains(char ch)
        {
            if (_Marks.Contains(ch))
                return true;
            return false;
        }
        public override IList<char> GetMarks()
        {
            return _Marks;
        }
    }
}
