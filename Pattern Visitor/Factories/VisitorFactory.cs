using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pattern_Visitor.Classes;
using Pattern_Visitor.Interfaces;

namespace Pattern_Visitor.Factories
{
    public class VisitorFactory
    {
        static Func<string> Selector(IElement el) =>
            el switch
            {
                Kid kid => kid.KidOperation,
                Parent parent => parent.ParentOperation,
                Teacher teacher => teacher.TeacherOperation,
                Assistant assistant => assistant.AssistantOperation,
                    _ => throw new ArgumentOutOfRangeException(nameof(el))
            };

        static Type ConcreteType(IElement el) =>
           el switch
           {
               Kid kid => kid.GetType(),
               Parent parent => parent.GetType(),
               Teacher teacher => teacher.GetType(),
               Assistant assistant => assistant.GetType(),
               _ => throw new ArgumentOutOfRangeException(nameof(el))
           };
        public static List<IVisitor> Get()
        {        
            return new List<IVisitor>
            {
                Doctor.Create("Ram", Selector),
                Salesman.Create("Sara", Selector),
                Doctor.Create("Pam", Selector),
                Doctor.Create("Smith", Selector),
                Nurse.Create("Jean", Selector),
                Nurse.Create("Beth", Selector),
                Dentist.Create("Tom", Selector)
            };
        }
    }
}
