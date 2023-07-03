using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Visitor.Factories;
using Visitor.Interfaces;

namespace Visitor.Classes
{
    public class Salesman : IVisitor
    {
        public string Name { get; set; }
        public Salesman(string name) => Name = name;
        public void Visit(Kid kid)
            => Console.WriteLine($"Salesman {Name} => Kid {kid.Name}: {kid.KidOperation()}");
        public void Visit(Parent parent)
            => Console.WriteLine($"Salesman {Name} => Parent {parent.Name}: {parent.ParentOperation()}");
        public void Visit(Teacher teacher)
            => Console.WriteLine($"Salesman {Name} => Teacher {teacher.Name}: {teacher.TeacherOperation()}");
    }

    public class ExtSalesman : Salesman, IExtVisitor
    {
        public ExtSalesman(string name) : base(name) { }
        public void Visit(Assistant assistant)
            => Console.WriteLine($"Doctor {Name} => Assistant {assistant.Name}: {assistant.AssistantOperation()}");
    }
}
