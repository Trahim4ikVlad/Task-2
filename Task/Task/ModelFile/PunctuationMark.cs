using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    class PunctuationMark:IPunctuationMark
    {
        public string Value { get; set; }

        public override string ToString()
        {
            return Value;
        }

        public PunctuationMark(string value)
        {
            this.Value = value;
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is PunctuationMark)
            {
                PunctuationMark mark = obj as PunctuationMark;
                if (this.ToString() == mark.ToString())
                    return true;
                else
                    return false;
            }

            return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }
    }
}
