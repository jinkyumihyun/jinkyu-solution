using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Visitor.Classes;

namespace Pattern_Visitor.Interfaces
{
    public interface IElement
    {
        string Name { get; }
        void Accept(IVisitor visitor);
    }
}
