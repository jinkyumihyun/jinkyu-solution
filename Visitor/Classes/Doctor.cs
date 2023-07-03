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
    public class Doctor : IVisitor
    {
        public string Name { get; }
        public Doctor(string name) => Name = name;
        public void Visit(Kid kid)
            => Console.WriteLine($"Doctor {Name} => Kid {kid.Name}: {kid.KidOperation()}");
        public void Visit(Parent parent)
            => Console.WriteLine($"Doctor {Name} => Parent {parent.Name}: {parent.ParentOperation()}");
        public void Visit(Teacher teacher)
            => Console.WriteLine($"Doctor {Name} => Teacher {teacher.Name}: {teacher.TeacherOperation()}");
    }
    public class ExtDoctor : Doctor, IExtVisitor
    {
        public ExtDoctor(string name) : base(name) { }   
        public void Visit(Assistant assistant)
            => Console.WriteLine($"Doctor {Name} => Assistant {assistant.Name}: {assistant.AssistantOperation()}");
    }

}
