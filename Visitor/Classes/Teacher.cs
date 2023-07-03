using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Classes
{
    public class Teacher : IElement
    {
        public string Name { get; }
        public Teacher(string name) => Name = name;
        public string TeacherOperation() => $"\"TeacherOperation\"";
        public void Accept(IVisitor visitor) => visitor.Visit(this);
    }
}
