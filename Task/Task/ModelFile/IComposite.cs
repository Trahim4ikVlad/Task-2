using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task.ModelFile
{
    interface IComposite
    {     
        IList<ISimple> Elements { get; set; }
        string Value { get; set; }

        int CountElement();
        IList<ISimple> GetElemens();
        IList<ISimple> CreateElements(IComposite source);

        IList<ISimple> SearchElement(ISimple source);
        bool Constains(ISimple simple);
    }

}
