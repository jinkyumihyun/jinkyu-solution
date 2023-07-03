using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plain.Classes
{
    public sealed class Singleton
    {       
        private static readonly Singleton singletonInstance = new Singleton();
        public static Singleton GetInstance()
        {
            Console.WriteLine($"Singleton.GetInstance: {++_cntReferences}th Reference returned");
            return singletonInstance;
        }
        private Singleton()
        {
            Console.WriteLine($"Singleton.Singleton: {++_cntCreate}th Instance Created");
        }
        private static int _cntCreate = 0;
        private static int _cntReferences = 0;
        public static int GetReferenceNo() { return _cntReferences; }

        //*************************************************
        
        private static int _testValue = 0;

        public int GetTestValue(int id)
        {
            Console.WriteLine($"Singleton.GetTestValue: id: {id}: {++_testValue}th TestValue returned.");
            return _testValue;
        }
     }
}
