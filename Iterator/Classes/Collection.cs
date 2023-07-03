using Iterator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Classes
{
    class Collection : ICollection
    {
        public Collection(List<IItem> list) 
            => _listItems = list ?? throw new ArgumentNullException(nameof(list));

        private List<IItem> _listItems = new List<IItem>();
        public IIterator CreateIterator() => new Iterator(this);
        public int Count => _listItems.Count; 
        public IItem GetItem(int Index)
            => (Index >= Count) ? NullItem.GetInstance() : _listItems[Index];
        public void AddItem(IItem item) => _listItems.Add(item);
        public void RemoveItem(IItem item) =>  _listItems.Remove(item);   
        public IItem this[int Index]
        {
            get => (Index >= Count) ? NullItem.GetInstance() : _listItems[Index];
            set
            {
                if (Index < Count)
                {
                    _listItems[Index] = value;
                }
                else
                {
                    throw new IndexOutOfRangeException("[set]");
                }
            }

        }
    }
}
