using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    public class Text:ICollection<Sentence>
    {
        private IList<Sentence> _sentens = new List<Sentence>(); 

        public IEnumerator<Sentence> GetEnumerator()
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public int Count { get { return _sentens.Count; } }
        public bool IsReadOnly { get { return false; } }
    }
}
