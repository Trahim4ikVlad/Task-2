using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    public class Word :IWord
    {
        public override string ToString()
        {
            return Value;
        }

        public string Value { get; set; }




        public int Length
        {
            get
            {
               return 0;
            }
        }
    }
}
