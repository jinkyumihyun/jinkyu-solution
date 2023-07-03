using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Visitor.Classes;

namespace Pattern_Visitor.Interfaces
{
    public interface IVisitor
    {
        string Name { get; }
        void Visit(IElement el);
    }
}
