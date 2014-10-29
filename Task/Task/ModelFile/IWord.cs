using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    public interface IWord:ISentenceElement
    {
        char[] GetValueChars();
        int Length { get; }
    }
}
