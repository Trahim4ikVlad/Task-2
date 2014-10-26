using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    public class Word :IWord
    {
        public string Value { get; set; }

        public int Length
        {
            get { return Value.Length; }
            set { value = Value.Length; }
        }

        public char[] GetValueChars()
        {
            return Value.ToCharArray();
        }

        public bool Equals(ISentenceElement obj)
        {
            if (obj == null)
                return false;

            Word word = obj as Word;
            if (word == null)
                return false;

            return word.Value == Value;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
