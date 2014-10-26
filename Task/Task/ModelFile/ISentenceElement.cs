using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task.ModelFile
{
    public interface ISentenceElement
    {
        string ToString();
        bool Equals(ISentenceElement obj);
    }
}
