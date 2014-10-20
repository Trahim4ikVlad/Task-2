using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile.Marks
{
    abstract public class PunctuationMark:IMark
    {
        public char Value { get; set; }

        public virtual bool Contains(char ch)
        {
            throw new NotImplementedException();
        }

        public virtual IList<char> GetMarks()
        {
            throw new NotImplementedException();
        }
    }
}
