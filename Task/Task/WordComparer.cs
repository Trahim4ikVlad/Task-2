using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task.ModelFile;

namespace Task
{
    public class WordComparer : IEqualityComparer<IWord>
    {
        public bool Equals(IWord x, IWord y)
        {
            
            if (Object.ReferenceEquals(x, y)) return true;

            
            if (Object.ReferenceEquals(x, null) || Object.ReferenceEquals(y, null))
                return false;

           
            return x.Length == y.Length && x.Value == y.Value;
        }

        public int GetHashCode(IWord word)
        {
            if (Object.ReferenceEquals(word, null)) return 0;

           
            int hashWordValue = word.Value == null ? 0 : word.Length.GetHashCode();

            
            int hashWordLength = word.Length.GetHashCode();


            return hashWordValue ^ hashWordLength;
        }
    }
}
