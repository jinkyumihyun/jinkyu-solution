using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Factories;
using Visitor.Interfaces;

namespace Visitor.Classes
{
    public class Nurse : IVisitor
    {
        public string Name { get; }
        public Nurse(string name) => Name = name;
        public void Visit(Kid kid)
            => Console.WriteLine($"Nurse {Name} => Kid {kid.Name}: {kid.KidOperation()}");
        public void Visit(Parent parent)
            => Console.WriteLine($"Nurse {Name} => Parent {parent.Name}: {parent.ParentOperation()}");
        public void Visit(Teacher teacher)
            => Console.WriteLine($"Nurse {Name} => Teacher {teacher.Name}: {teacher.TeacherOperation()}");
    }
    public class ExtNurse : Nurse, IExtVisitor
    {
        public ExtNurse(string name) : base(name) { }
        public void Visit(Assistant assistant)
            => Console.WriteLine($"Nurse {Name} => Assistant {assistant.Name}: {assistant.AssistantOperation()}");
    }
}
