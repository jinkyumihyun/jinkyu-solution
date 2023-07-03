using Cache.Interfaces;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cache.Classes
{
    public sealed class SingletonCache : ICache
    {  
        private static readonly SingletonCache singletonInstance = new SingletonCache();
        public static SingletonCache GetInstance()
        {
            Console.WriteLine($"{++_referenceCnt}th SingletonCache Instance Reference Returned");
            return singletonInstance;
        }
        private SingletonCache() => Console.WriteLine($"{++_intanceCnt}th SingletonCache Instance Created");

        private static int _intanceCnt = 0;
        private static int _referenceCnt = 0;

        //**************************************************************************

        private ConcurrentDictionary<object, object> concurrentDictionary = new ConcurrentDictionary<object, object>();
        public bool Add(object key, object value) => concurrentDictionary.TryAdd(key, value);
        public bool Update(object key, object value)
            => concurrentDictionary.ContainsKey(key) ? 
            (concurrentDictionary.TryRemove(key, out object? RemovedValue) && concurrentDictionary.TryAdd(key, value)) : false;
        public object? Get(object key)
            => concurrentDictionary.ContainsKey(key) ? concurrentDictionary[key] : null;
        public bool Remove(object key) => concurrentDictionary.TryRemove(key, out object? value);
        public void Clear() => concurrentDictionary.Clear();
        public void PrintDetails(string message) => Console.WriteLine(message);
    }

}
