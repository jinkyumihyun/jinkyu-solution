using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Classes;
using Visitor.Interfaces;
using static Visitor.Classes.Dentist;

namespace Visitor.Factories
{
    public class VisitorFactory
    {
        public static List<IVisitor> Get()
        {
            return new List<IVisitor>
            {
                new ExtDoctor("Ram"),
                new ExtSalesman("Sara"),
                new ExtDoctor("Pam"),
                new ExtDoctor("Smith"),
                new ExtNurse("Jean"),
                new ExtNurse("Beth"),
                new ExtDentist("Tom")
            };
        }
    }
}
