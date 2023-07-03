using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Visitor.Interfaces;

namespace Pattern_Visitor.Classes
{
    public class Assistant : IElement
    {
        public string Name { get; }
        public Assistant(string name) => Name = name;
        public string AssistantOperation() => $"\"AssistantOperation\"";
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
    
}
