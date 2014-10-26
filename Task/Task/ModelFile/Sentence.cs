using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    public class Sentence : ICollection<ISentenceElement>
    {

        private  ICollection<ISentenceElement> _elements  =  new Collection<ISentenceElement>();

        public void Add(ISentenceElement item)
        {
            _elements.Add(item);
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }

            Sentence sentence = obj as Sentence;

            if ((System.Object)sentence == null)
            {
                return false;
            }

            return obj.ToString() == ToString();
        }

        public bool Equals(Sentence obj)
        {
            if (obj == null)
                return false;
            return obj.ToString() == this.ToString();
        }

        public void Clear()
        {
            _elements.Clear();
        }

        public bool Contains(ISentenceElement item)
        {
            throw new NotImplementedException();
        }

        public void CopyTo(ISentenceElement[] array, int arrayIndex)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
