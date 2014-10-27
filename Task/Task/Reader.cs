using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    public class TextReader
    {
        private string _sourceDirictory = @"D:\Epam\";

        private string _data;

        public void ReadFile(string path)
        {
            string fullpath = _sourceDirictory + path + ".txt";

            try
            {
                using (StreamReader sr = new StreamReader(fullpath))
                {
                    _data = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
            } 
 
        }

        public string GetData()
        {
            return _data;
        } 
    }
}
