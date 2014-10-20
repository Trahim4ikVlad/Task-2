using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    interface IMark
    {
        char Value { get; set; }
        bool Contains(char ch);
        IList<char> GetMarks(); 
    }
}
