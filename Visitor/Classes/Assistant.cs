using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Classes
{
    public class AbstractAssistant : IElement
    {
        public string Name { get; }
        public AbstractAssistant(string name) => Name = name;
        public string AssistantOperation() => $"\"AssistantOperation\"";
        public void Accept(IVisitor visitor) { }
    }
    public class Assistant : AbstractAssistant, IExtElement
    {
        public Assistant(string name) : base(name) { }
        public void Accept(IExtVisitor visitor) => visitor.Visit(this);
    }
}
