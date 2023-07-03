using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Classes;

namespace Visitor.Interfaces
{
    public interface IElement
    {
        string Name { get; }
        void Accept(IVisitor visitor);
    }

    public interface IExtElement : IElement
    {
        void Accept(IExtVisitor visitor);
    }
}
