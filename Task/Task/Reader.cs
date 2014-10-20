using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    class Reader
    {
        public string Path { get; set; }
        Reader(string path)
        {
            
        }
        public void CreateFile(string path)
        {
            File.Create(path);
        }
    }
}
