using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Task.ModelFile;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string path = @"D:\Epam\test.txt";
            string data;

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    data = sr.ReadToEnd();
                }
            }
            catch (Exception e)
            {
                 throw new Exception("The file could not be read:", e);
            } 


            Regex regex = new Regex("\\s+");
            data = regex.Replace(data, " ");
          
            Text text = new Text(data);
             
            foreach (var s in text)
            {
                foreach (var c in s)
                {
                    if (c is  IPunctuationMark)
                    {
                        Console.WriteLine(c);
                    } 
                }
            }

        }
    }
}
