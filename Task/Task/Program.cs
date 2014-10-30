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
            /*
            foreach (var sen in text)
            {
                foreach (var element in sen)
                {
                    Console.WriteLine(element.Value);
                }
            }
            */

            
            Console.WriteLine("After sorting:");
            text.OrderBySentence();
            
            foreach (var sen in text)
            {
                Console.WriteLine(sen.Value);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("In all interrogative sentences of the text to find and print without the repetition of words of a given length:");

            //text.InterrogativeSentenceNoRepeat(5);
            //text.RemoveWordBeginsWithConsonant(3);

            foreach (var sen in text)
            {
                if (sen.Count > 10)
                {
                    sen.ReplaceSpecifiedSubstring(5,"Hello!!!!!");
                }
            }

            foreach (var sen in text)
            {
                foreach (var w in sen)
                {
                    Console.Write(w.Value+" ");
                }
            }
        }
    }
}
