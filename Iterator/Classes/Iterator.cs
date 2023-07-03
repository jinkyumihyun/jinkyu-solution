using Iterator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Classes
{
    class Iterator : IIterator
    {
        private ICollection _collection;
       
        private int Current = 0;

        private readonly int Step = 1;
        public Iterator(ICollection collection) 
            =>  this._collection = collection ?? throw new ArgumentNullException(nameof(collection));
        public IItem First()
        {
            Current = 0;
            return _collection.GetItem(Current);
        }
        public IItem Next()
        {
            Current += Step;
            return !IsCompleted ? _collection.GetItem(Current) : NullItem.GetInstance();
        }
        public bool IsCompleted => Current >= _collection.Count; 
    }
}
