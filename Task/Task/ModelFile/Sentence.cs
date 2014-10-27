using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    public class Sentence : ICollection<ISentenceElement>
    {
        private  IList<ISentenceElement> _elements  =  new List<ISentenceElement>();

        public string Value { get; set; }

        public void Add(ISentenceElement item)
        {
            _elements.Add(item);
        }

        public bool Equals(Sentence obj)
        {
            if (obj == null)
                return false;

            return obj.Value == this.Value;
        }

        public void Clear()
        {
            _elements.Clear();
        }

        public bool Contains(ISentenceElement item)
        {
            bool found = false;

            foreach (var e in _elements)
            {
                if (e.Equals(item))
                {
                    found = true;
                }
            }

            return found;
        }

        public void CopyTo(ISentenceElement[] array, int arrayIndex)
        {
            for (int i = 0; i < _elements.Count; i++)
            {
                array[i] =(ISentenceElement) _elements[i];
            }
        }

        public int Count
        {
            get { return _elements.Count; }
        }

        public bool IsReadOnly
        {
            get { return false; }
        }

        public bool Remove(ISentenceElement item)
        {
            return true;
        }

        public IEnumerator<ISentenceElement> GetEnumerator()
        {
           return _elements.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
