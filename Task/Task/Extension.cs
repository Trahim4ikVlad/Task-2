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

        
        public static List<ISentenceElement> InterrogativeSentenceNoRepeat(this Text text, int length)
        {
            
         return    text.Where(x => x.Contains(new PunctuationMark("?"))).SelectMany(x=>x).Where(x =>
         {
             var word = x as IWord;
             return word != null && word.Length == length;
         }).ToList();
                     
            /*
            foreach (var interrogativeSentence in interrogativeSentences)
            {
                interrogativeSentence.Where(x => x.Value.Length == length && x is IWord).Distinct();
               /* 
                foreach (ISentenceElement w in interrogative)
                {
                    interrogativeSentence.Remove(w);
                    interrogativeSentence.Remove(w);
                }*/ 
        }

        public static void RemoveWordBeginsWithConsonant(this Text text, int length)
        {
            foreach (var sentence in text)
            {
                foreach (var element in sentence)
                {

                }
            }
        }
    }
}
