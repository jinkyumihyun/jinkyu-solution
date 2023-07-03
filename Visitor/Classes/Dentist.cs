using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Interfaces;

namespace Visitor.Classes
{
    public class Dentist : IVisitor
    {
        public string Name { get; }
        public Dentist(string name) => Name = name;
        public void Visit(Kid kid)
            => Console.WriteLine($"Dentist {Name} => Kid {kid.Name}: {kid.KidOperation()}");
        public void Visit(Parent parent)
            => Console.WriteLine($"Dentist {Name} => Parent {parent.Name}: {parent.ParentOperation()}");
        public void Visit(Teacher teacher)
            => Console.WriteLine($"Dentist {Name} => Teacher {teacher.Name}: {teacher.TeacherOperation()}");
        public class ExtDentist : Dentist, IExtVisitor
        {
            public ExtDentist(string name) : base(name) { }
            public void Visit(Assistant assistant)
                => Console.WriteLine($"Dentist {Name} => Assistant {assistant.Name}: {assistant.AssistantOperation()}");
        }
    }
}
