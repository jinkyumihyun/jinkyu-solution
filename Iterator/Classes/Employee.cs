using HelperLib;
using Iterator.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.Classes
{
    class Elempoyee : IItem
    {
        public int ID { get;  }
        public string Name { get; }
        public Elempoyee(string name, int id) 
            => (Name, ID) = (Helper.IsNullWhite(name) ?? throw new ArgumentException(nameof(name)), id);
        public override string ToString() => $"name: {Name}, id: {ID}";
    }
}
