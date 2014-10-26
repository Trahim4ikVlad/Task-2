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
        int Length { get; set; }
    }
}
