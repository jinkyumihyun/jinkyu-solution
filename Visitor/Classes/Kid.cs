using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Classes
{
    public class Kid : IElement
    {
        public string Name { get; }
        public Kid(string name) => Name = name;
        public string KidOperation() => $"\"KidOperation\"";
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
