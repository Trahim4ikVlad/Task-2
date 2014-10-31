using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    public class Text:ICollection<Sentence>
    {
        private IList<Sentence> _sentens = new List<Sentence>();

        public string Value { get; set; }

        public Text(string value)
        {
            this.Value = value;
            foreach (var sentence in this.GetSentenceValue())
            {
                if(sentence.Length>0)
                Add(new Sentence(sentence));
            }
        }

        private string GetText()
        {
            StringBuilder sb = new StringBuilder();

            foreach (Sentence sentence in _sentens)
            {
                sb.Append(sentence + " ");
            }
            return sb.ToString();
        }

        public override string ToString()
        {
            return GetText();
        }

        public void OrderBySentence()
        {
           _sentens = _sentens.OrderBy(x => x.CountWords()).ToList();
        }

        public IEnumerator<Sentence> GetEnumerator()
        {
            return _sentens.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Sentence item)
        {
            _sentens.Add(item);
        }

        public void Clear()
        {
            _sentens.Clear();
        }

        public bool Contains(Sentence item)
        {
            bool found = false;

            foreach (var sentence in _sentens)
            {
                if (sentence.Equals(item))
                {
                    found = true;
                }
            }

            return found;
        }

        public void CopyTo(Sentence[] array, int arrayIndex)
        {
            for (int i = 0; i < _sentens.Count; i++)
            {
                array[i] = (Sentence)_sentens[i];
            }
        }

        public bool Remove(Sentence item)
        {
            bool result = false;

            for (int i = 0; i < _sentens.Count; i++)
            {
                Sentence cur = (Sentence)_sentens[i];
                if (cur.Equals(item))
                {
                    _sentens.RemoveAt(i);
                    result = true;
                    break;
                }
            }
            return result;
        }

        public int Count { get { return _sentens.Count; } }

        public bool IsReadOnly { get { return false; } }

        public  void RemoveWordBeginsWithConsonant(int length)
        {
            Regex consonant = new Regex("[^aeiou]");

            var words = _sentens.SelectMany(x=>x).
                Where(x => (x is IWord) && consonant.IsMatch(x.Value[0].ToString()))
                .Cast<IWord>().Where(x=>x.Length==length).ToList();

            foreach (Sentence sentence in _sentens)
            {
                foreach (var element in words)
                {
                    if (sentence.Contains(element))
                    {
                        sentence.Remove(element);
                    }
                      
                }
            }
                 
        }
    }
}
