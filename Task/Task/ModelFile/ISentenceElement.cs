using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Task.ModelFile
{
    public interface ISentenceElement
    {
        string Value { get; set; }
      
        string ToString();
        bool Equals(Object obj);
    }
}
