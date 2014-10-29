using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Task.ModelFile;

namespace Task
{
    public static class Extension
    {
        public static int WordCount(this Sentence sentence)
        {
            return sentence.Value.Split(new char[] { ' ', '.', '?' },
                             StringSplitOptions.RemoveEmptyEntries).Length; 
        }

       
        
        public static void ParseSentence(this Sentence sentence)
        {
            string data = sentence.Value;
         
            string[] chunks = data.Split(' ');

            StringBuilder sb = new StringBuilder();

            Regex wordRegex = new Regex("[a-zA-Z0-9_]");

            Regex punctRegex = new Regex("[-.?!,:]");

            foreach (string s in chunks)
            {
                foreach (char c in s)
                {
                    if (punctRegex.IsMatch(c.ToString()))
                    {
                        sentence.Add(new PunctuationMark(c.ToString()));
                    }
                    if(wordRegex.IsMatch(c.ToString()))
                    {
                        sb.Append(c);
                    }
                }
                if (sb.Length <= 0) continue;
                sentence.Add(new Word(sb.ToString()));
                sb.Clear();
            }
        }

        public static string[] GetSentenceValue(this Text text)
        {
            string pattern = @"(?<=[\.!\?])\s+";
            return Regex.Split(text.Value, pattern);
        }
        /*
        public static bool IsPunctuationMark(this char ch)
        {
            char[] marks = { '.', '!', '?',',','-',':',';'};
            return marks.Contains(ch);
        }*/
    }
}
