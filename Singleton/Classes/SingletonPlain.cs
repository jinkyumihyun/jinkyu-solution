using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPlain.Classes
{
    //sealed which will ensure that it cannot be inherited.dealing with the nested class.
    public sealed class SingletonPlain
    {
        private static SingletonPlain Instance = new SingletonPlain();
        public static SingletonPlain GetInstance()
        {
            Console.WriteLine($"GetInstance: {++_cntInstances}");
            return Instance;
        }
        private SingletonPlain()
        {
            Console.WriteLine($"SingletonPlain: {++_cntCreations}");
        }

        private static int _cntCreations = 0;
        private static int _cntInstances = 0;

        //**********************************************************************

        private int _testValue = 0;
        public int GetTestValue()
        {
            return ++_testValue;
        }

        //public class DerivedSingleton : SingletonInitial
        //{
        //}
    }
}
