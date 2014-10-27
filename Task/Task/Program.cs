using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.ModelFile;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            TextReader red = new TextReader();

            string filename = "test";
           
            red.ReadFile(filename);
            Console.WriteLine(red.GetData());

        }
    }
}
