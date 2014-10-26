using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    class PunctuationMark:IPunctuationMark
    {
        public char Value { get; set; }

        public override string ToString()
        {
            return Value.ToString();
        }
    }
}
