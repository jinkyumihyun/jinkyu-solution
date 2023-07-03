using Observers.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Classes
{
    public class Notice : INotice
    {
        public Guid Id { get; }
        public string Item { get; }
        public int Price { get; }
        public string Store { get; }
        public Notice(string item, int price, string store)
            => (Id, Item, Price, Store) = (Guid.NewGuid(), item, price, store);
    }
}
