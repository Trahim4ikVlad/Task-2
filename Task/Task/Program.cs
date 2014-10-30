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

            string inputPath = @"D:\Epam\input.txt";
            string outputPath = @"D:\Epam\output.txt";

            string data;

            try
            {
                using (StreamReader sr = new StreamReader(inputPath))
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
          
            StringBuilder sb = new StringBuilder();

            Text text = new Text(data);

            sb.AppendLine("Source.........");
            sb.Append(text.Value);
            text.OrderBySentence();

            sb.AppendLine();
            sb.AppendLine("After sorting.........");
            foreach (var sen in text)
            {  
                sb.Append(sen.Value);
                sb.AppendLine();
            }
            sb.AppendLine("Repeated words in interrogative sentences.............");
            foreach (var t in text.InterrogativeSentenceNoRepeat(5))
            {
                sb.AppendLine(t.Value);
            }

            sb.AppendLine("After remove..................");
            text.RemoveWordBeginsWithConsonant(8);

            foreach (var sen in text)
            {
                foreach (var w in sen)
                {
                    sb.AppendLine(w.Value + " ");
                }
            }

            using (StreamWriter file = new System.IO.StreamWriter(outputPath, true))
            {
                file.Write(sb.ToString());
                file.Close();
            }
        }
    }
}
