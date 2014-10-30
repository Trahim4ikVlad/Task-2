using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using Task.ModelFile;

namespace Task
{
    public static class Extension
    {
     
        public static void ParseSentence(this Sentence sentence)
        {
            string data = sentence.Value;
         
            string[] chunks = data.Split(' ');

            StringBuilder sb = new StringBuilder();

            Regex wordRegex = new Regex("[a-zA-Z0-9_#]");
            
            //Regex interPunctRegex = new Regex("[-,:;]");

            Regex punctRegex = new Regex("[-,;:.?!]");


            foreach (string s in chunks)
            {
                foreach (char c in s)
                {
                    if(wordRegex.IsMatch(c.ToString()))
                    {
                        sb.Append(c);
                    }
                    if (punctRegex.IsMatch(c.ToString()))
                    {
                        if (sb.Length > 0)
                        {
                            sentence.Add(new Word(sb.ToString()));
                            sb.Clear();
                        }
                        sentence.Add(new PunctuationMark(c.ToString()));
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

        
        public static IList<IWord> InterrogativeSentenceNoRepeat(this Text text, int length)
        {

         return  text.Where(x => x.Contains(new PunctuationMark("?"))).SelectMany(x => x).Where(x =>
         {
             var word = x as IWord;
             return word != null && word.Length == length;
         }).Distinct(null) as IList<IWord>;

        }

        public static List<ISentenceElement> RemoveWordBeginsWithConsonant(this Text text, int length)
        {
            Regex consonant = new Regex("[^aeiou]");

            foreach (var s in text.SelectMany(x => x).Where(x => (x is IWord) && consonant.IsMatch(x.Value[0].ToString()))
                .ToList())
            {
               
            }
            return text.SelectMany(x => x).Where(x => (x is IWord) && consonant.IsMatch(x.Value[0].ToString()))
                .ToList();
        }

        public static void ReplaceSpecifiedSubstring(this Sentence sentence, int length, string substring)
        {
            foreach (ISentenceElement element in sentence)
            {
                var word = element as IWord;
                
                if (word!=null)
                {
                    if (word.Length == length)
                    {
                        word.Value = substring;
                    }
                }
            }
        }

        
    }
}
