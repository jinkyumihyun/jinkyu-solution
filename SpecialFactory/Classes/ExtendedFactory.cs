using SpecialFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFactory.Classes
{
    internal class ExtendedFactory : Factory
    {
        public static ExtraFactory Get() => new ExtraFactory();
        public class ExtraFactory : GeneralFactory
        {
            public EightNineFactory Extra() => new EightNineFactory();
        }
        public class EightNineFactory
        {
            public IItem Eight() => new I8();
            public IItem Nine() => new I9();
        }
    }
}
