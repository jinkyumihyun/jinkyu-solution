using Iterator.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Interface
{
    interface IIterator
    {
        IItem First();
        IItem Next();
        bool IsCompleted { get; }
    }
}
