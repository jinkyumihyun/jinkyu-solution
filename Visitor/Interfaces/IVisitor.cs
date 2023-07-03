using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Classes;

namespace Visitor.Interfaces
{
    public interface IVisitor
    {
        string Name { get; }
        void Visit(Kid kid);
        void Visit(Parent parent);
        void Visit(Teacher teacher);
    }

    public interface IExtVisitor : IVisitor
    {
        void Visit(Assistant assistant);
    }

    public interface ISpecialVisitor
    {
        string Name { get; }
        void Visit(IElement el);
    }
}
