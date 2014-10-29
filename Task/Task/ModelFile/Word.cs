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
        }

        public Word(string value)
        {
            this.Value = value;
        }

        public char[] GetValueChars()
        {
            return Value.ToCharArray();
        }

        public override bool Equals(object obj)
        {
            if (obj != null && obj is Word)
            {
                Word word = obj as Word;
                if (this.ToString() == word.ToString())
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

        public override string ToString()
        {
            return Value;
        }
    }
}
