using Iterator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Classes
{
    public sealed class NullItem : IItem
    {
        private NullItem() { }

        private static readonly NullItem s_instance = new NullItem();

        public static NullItem GetInstance() => s_instance;

        //*******************************************************
        public int ID => default;
        public string? Name => default;
        public override string ToString() => string.Empty;
    }
}
