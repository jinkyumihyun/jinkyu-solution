using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Interfaces
{
    public interface ICache
    {
        bool Add(object key, object value);
        bool Update(object key, object value);       
        bool Remove(object key);
        void Clear();
        object Get(object key);
    }
}
