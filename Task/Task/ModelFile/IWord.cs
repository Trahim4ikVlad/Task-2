using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    public interface IWord:ISentenceElement
    {
        string Value { get; set; }
        char[] GetValueChars();
        int Length { get; set; }
    }
}
