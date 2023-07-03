using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Classes
{
    public class ArrayCollection<T>
    {
        T[] _array;
        public ArrayCollection(T[] array) 
            => _array = array ?? throw new ArgumentNullException(nameof(array));
        public IEnumerable<T> GetItem()
        {
            for (int i = 0; i < _array.Length; ++i) 
            {
                yield return _array[i];
            }
        }
    }
}
