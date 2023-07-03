using SpecialFactory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialFactory.Classes
{
    public class Factory
    {
        public static GeneralFactory Get() => new GeneralFactory();
        public class GeneralFactory
        {
            public UpperFactory Upper() => new UpperFactory();
            public LowerFactory Lower() => new LowerFactory();
        }

        public class UpperFactory
        {
            public FourFiveFactory FourFive() => new FourFiveFactory();
            public SixSevenFactory SixSeven() => new SixSevenFactory();
        }
        public class FourFiveFactory
        {
            public IItem Five() => new I5();
            public IItem Four() => new I4();
        }
        public class SixSevenFactory
        {
            public IItem Seven() => new I7();
            public IItem Six() => new I6();
        }
        public class LowerFactory
        {
            public ZeroOneFactory ZeroOne() => new ZeroOneFactory();
            public TwoThreeFactory TwoThree() => new TwoThreeFactory();
        }
        public class ZeroOneFactory
        {
            public IItem Zero() => new I0();
            public IItem One() => new I1();
        }
        public class TwoThreeFactory
        {
            public IItem Two() => new I2();
            public IItem Three() => new I3();
        }
    }
}
