using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Interface
{
    interface ICollection
    {
        IIterator CreateIterator();
        IItem GetItem(int idx);
        int Count { get; }
    }
}
