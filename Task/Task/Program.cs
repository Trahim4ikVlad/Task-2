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

            string inputPath = @"C:\Users\Vlad\Documents\GitHub\Task-2\Task\input.txt";
            string outputPath = @"C:\Users\Vlad\Documents\GitHub\Task-2\Task\output.txt";

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
            sb.Append(text);

            //sort
            text.OrderBySentence();
            

            sb.AppendLine();
            sb.AppendLine();

            sb.AppendLine("After sorting.........");
            sb.Append(text);
           
            sb.AppendLine();
            sb.AppendLine();
         
            
            
            sb.AppendLine("Repeated words in interrogative sentences.............");

           
            //Repeated words in interrogative sentences
            foreach (var t in text.InterrogativeSentenceNoRepeat(8))
            {
                sb.AppendLine(t.Value);
            }


            sb.AppendLine();
            sb.AppendLine("After remove..................");

            
            
            //deleting the word begins with a consonant
            text.RemoveWordBeginsWithConsonant(10);
 
           
            foreach (var sen in text)
            {
               sb.AppendLine(sen.ToString());
            }


            //replacing words with a new substring
            foreach (Sentence sentence in text)
            {
                if (sentence.Count < 4)
                {
                    sentence.ReplaceNewSubstring((x =>
                    {
                        var word = x as IWord;
                        return word != null && word.ToString() == "No";
                    }), "Hello World");
                }
            }



            sb.AppendLine();
            sb.AppendLine("After replace...................");


            foreach (Sentence sentence in text)
            {
                sb.AppendLine(sentence.ToString());
            }


            using (StreamWriter file = new System.IO.StreamWriter(outputPath, true))
            {
                file.Write(sb.ToString());
                file.Close();
            }
        }
    }
}
