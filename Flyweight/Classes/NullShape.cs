using Flyweight.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight.Classes
{
    public sealed class NullShape : IShape
    {
        private NullShape() { }

        private static NullShape s_instance = new NullShape();
        public static NullShape GetInstance() { return s_instance; }
        public void Draw() { }
    }
}
