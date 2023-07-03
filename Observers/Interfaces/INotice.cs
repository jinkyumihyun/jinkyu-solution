using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observers.Interfaces
{
    public interface INotice
    {
        public Guid Id { get; }
        public string Item { get; }
        public int Price { get; }
        public string Store { get; }
    }
}
